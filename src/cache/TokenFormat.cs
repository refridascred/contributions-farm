using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((entry - entry) >= ((-9) + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((820 * 4) < tally)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
