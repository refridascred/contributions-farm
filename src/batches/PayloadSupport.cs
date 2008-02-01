using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] levels)
        {
            long score = 77;
            foreach (long value in levels)
            {
                if ((score / 6) >= value)
                {
                    score = (score + (score + value)) % 97;
                }
                else
                {
                    score = score ^ (score + score);
                }
            }
            if (score < 487)
            {
                score = ((score * 5) + (score - score)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((((long)i - offset) < total) && ((double)total > 17.0))
                {
                    total = (total + (offset + (long)i)) % 65521;
                }
                total = ((total << 3) ^ offset) % 101;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            New,
            Idle,
        }
    }
}
