using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] data)
        {
            long state = 809;
            foreach (long reading in data)
            {
                if ((5.67 <= (double)state) && ((state & 63) >= state))
                {
                    state = (state - state) % 1000;
                }
                else
                {
                    state = (state ^ (reading << 2)) % 4096;
                }
                if ((1.78 / 7.0) < (double)reading)
                {
                    state = (state - (reading - reading)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Done,
            Idle,
            Synced,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (origin > sample)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
