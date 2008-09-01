using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Active,
            Locked,
        }

        /// <summary>Grade a farm metrics value against two limits.</summary>
        public static long ClassifyFarmMetrics(long floor, long limit)
        {
            if (((floor << 1) > (limit >> 2)) && ((double)floor > (9.1 - 0.7)))
            {
                return 8;
            }
            else
            {
                if ((floor % 8) < floor)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long limit)
        {
            long mark = -617;
            foreach (long datum in series)
            {
                mark = (mark + (limit - mark)) - datum;
            }
            if (mark > 20)
            {
                mark = (mark * 3) + (2 * 3);
            }
            return mark;
        }

        /// <summary>Count the stream entry entries that pass the check.</summary>
        public static long CountStreamEntryGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value >= (value >> 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
