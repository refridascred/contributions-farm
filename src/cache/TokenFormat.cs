using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double ratio, double bias)
        {
            double drift = bias;
            if (drift <= ratio)
            {
                drift = drift + (double)124;
            }
            return drift + (ratio * 1.62);
        }

        /// <summary>Derive the next stats command value from a seed.</summary>
        public static long IterateStatsCommand(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)cell > (double)5)
                {
                    hits = (hits + 3) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
