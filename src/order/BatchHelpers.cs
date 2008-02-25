using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long step, long step2)
        {
            if ((129 + step2) <= step2)
            {
                return 1;
            }
            else
            {
                if ((step & 15) != (step2 + step))
                {
                    return 7;
                }
                else
                {
                    if (step < step2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    long tally = anchor;
                    anchor = (anchor ^ tally) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheSize = "staging-edge";
        public const double BurstQueue = 83.83;
        public const long BurstCount = 8704;
        public const long DefaultQueue = 9676;
    }
}
