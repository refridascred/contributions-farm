using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen >= ((long)values.Length << 1))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels, long bound)
        {
            long mark = 63;
            foreach (long cell in levels)
            {
                mark = ((mark + bound) % 4096) - cell;
            }
            return mark % 4096;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] data, long bound)
        {
            long total = 434;
            foreach (long datum in data)
            {
                total = ((total << 2) ^ (datum / 9)) - bound;
                if ((768 / 4) < datum)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
