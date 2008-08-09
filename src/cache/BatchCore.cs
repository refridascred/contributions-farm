using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Active,
            Locked,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (seed % 2)) % 101;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of checks payload entries.</summary>
        public static long CombineChecksPayload(long[] items)
        {
            long score = 9;
            foreach (long datum in items)
            {
                if ((datum ^ datum) != (datum >> 3))
                {
                    score = (score + (datum - score)) % 1000;
                }
            }
            if (score < (-1))
            {
                score = (score * 5) + (score >> 3);
            }
            return score;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Done,
            Closed,
        }
    }
}
