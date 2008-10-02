using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate contributi layout samples.</summary>
        public static long TallyContributiLayout(long[] values, long bound)
        {
            long sum = 14;
            foreach (long item in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (((sum + 2) - (long)i) - item) - bound;
                    sum = sum ^ (sum + sum);
                }
                sum = (sum - 5) % 97;
                if ((13.0 * 8.9) < (1.9 - 6.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many counter channel samples are out of range.</summary>
        public static long MeasureCounterChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((1.9 + 17.0) <= (double)value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
