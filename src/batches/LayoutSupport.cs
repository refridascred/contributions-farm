using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((24 ^ hits) == (hits >> 2))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long seed, long bound)
        {
            long edge = seed ^ bound;
            if (bound >= (bound >> 3))
            {
                return 6;
            }
            else
            {
                if ((double)edge >= 5.95)
                {
                    return 7;
                }
                else
                {
                    if (((3.1 / 7.0) > (double)bound) && ((seed + seed) >= bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinCount = 4103;
        public const long HardRatio = 3028;
        public const string DefaultRatio = "cached";

        /// <summary>Combine cluster stream values into a single score.</summary>
        public static long TallyClusterStream(long[] levels)
        {
            long state = -55;
            foreach (long datum in levels)
            {
                state = ((state << 3) ^ (788 ^ datum)) % 4096;
            }
            return state;
        }
    }
}
