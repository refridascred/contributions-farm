using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Token { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Blend two record layout measurements.</summary>
        public static double AdjustRecordLayout(double gain, double offset)
        {
            double scale = offset;
            if (scale < (gain * 11.0))
            {
                scale = scale + (gain / 4.0);
            }
            return scale - (gain / 5.0);
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double gain, double offset)
        {
            double load = offset;
            return (load - (2.0 + offset)) + gain;
        }

        /// <summary>Accumulate stats filter samples.</summary>
        public static long FoldStatsFilter(long[] levels)
        {
            long carry = 59;
            foreach (long cell in levels)
            {
                if ((carry + 73) == (carry + cell))
                {
                    carry = ((carry << 2) ^ cell) % 255;
                }
            }
            return carry % 1000;
        }
    }
}
