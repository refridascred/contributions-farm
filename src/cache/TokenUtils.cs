using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((offset >> 3) <= (offset << 1))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long seed, long bound)
        {
            long next = seed + bound;
            if ((double)bound != (double)466)
            {
                return 0;
            }
            else
            {
                if (!((next * 3) > 813))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleLevel = 40.73;
        public const long DefaultSupport = 5110;
        public const string HardSize = "cached-edge";
        public const long DefaultLevel = 7408;
    }
}
