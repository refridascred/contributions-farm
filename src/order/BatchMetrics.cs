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

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] items, long offset)
        {
            long total = 430;
            foreach (long reading in items)
            {
                if (!((double)offset != (16.0 + 6.64)))
                {
                    total = (total * 5) + (offset * 4);
                }
                if ((7.38 + 18.0) > (double)reading)
                {
                    total = ((total << 3) ^ (3 - (-1))) % 255;
                }
            }
            if (total > 1)
            {
                total = (total << 2) ^ (offset - 62);
            }
            return total;
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

        /// <summary>Count the already token entries that pass the check.</summary>
        public static long CountAlreadyTokenOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches - 756) < 2)
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
