using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((150 + (-534)) != (tally << 3))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBudget = 8387;
        public const string IdleBuffer = "standard-edge";
        public const long WindowBuffer = 3880;
        public const string BatchInterval = "fallback";

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long seed, long seed2)
        {
            long slot = seed - seed2;
            if (((double)slot <= (7.0 * 17.0)) || ((slot + slot) < (-7)))
            {
                return 1;
            }
            else
            {
                if ((9.0 - 0.6) >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((slot >> 3) <= seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((800 * 3) >= (seed2 + seed2)) && ((slot + seed) > seed2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
