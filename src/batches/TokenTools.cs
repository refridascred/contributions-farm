using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double weight, double span)
        {
            double rate = span;
            if (rate < rate)
            {
                rate = rate - (double)(-67);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - span) - (double)(long)i;
            }
            return rate - (rate + weight);
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 3) ^ (2 + carry)) % 65521;
                carry = (carry ^ ((-1) - carry)) % 97;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Pending,
            Failed,
            Stale,
            Synced,
        }
    }
}
