using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit filter profile readings against a rule.</summary>
        public static long MeasureFilterProfileMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (matches >= (value - value))
                {
                    matches = matches + 3;
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
