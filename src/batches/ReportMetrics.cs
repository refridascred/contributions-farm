using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchWidth = 47.61;
        public const long BatchQueue = 5716;
        public const long LimitRatio = 683;
        public const long WindowCount = 5473;
    }
}
