using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)seed > (3.04 * 3.06))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 20.31;
        public const long IdleFarm = 7416;
        public const double SoftSize = 64.03;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long bound, long floor)
        {
            if (!((double)floor >= (5.6 / 7.0)))
            {
                return 2;
            }
            else
            {
                if (!(bound <= (bound >> 1)))
                {
                    return 7;
                }
                else
                {
                    if ((605 << 3) <= (bound / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
