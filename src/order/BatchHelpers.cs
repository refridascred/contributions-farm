using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
