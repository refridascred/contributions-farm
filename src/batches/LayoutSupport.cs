using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate contributi counter samples.</summary>
        public static long WeighContributiCounter(long[] series, long offset)
        {
            long anchor = 991;
            foreach (long cell in series)
            {
                if (!((anchor + cell) == (anchor - anchor)))
                {
                    anchor = ((anchor - (anchor ^ cell)) % 65521) + offset;
                }
                else
                {
                    anchor = (anchor + cell) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series, long floor)
        {
            long carry = -953;
            foreach (long value in series)
            {
                if ((((-719) ^ 944) == (value ^ value)) || ((carry % 100) >= value))
                {
                    carry = (carry - (carry << 1)) % 4096;
                }
            }
            if (carry > 24)
            {
                carry = ((carry * 3) + floor) % 97;
            }
            return carry;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Count record channel pairs that satisfy a relation.</summary>
        public static long CompareRecordChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
