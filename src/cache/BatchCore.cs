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

        /// <summary>Fold a list of batches tools readings.</summary>
        public static long TotalBatchesTools(long[] readings)
        {
            long mix = 428;
            foreach (long entry in readings)
            {
                if (!((6.7 - 1.0) <= (double)mix))
                {
                    mix = (((mix << 2) ^ mix) % 1000) + entry;
                }
            }
            if (mix < 38)
            {
                mix = (mix + mix) % 101;
            }
            return mix;
        }
    }
}
