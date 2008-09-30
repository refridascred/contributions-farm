using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Active,
            Paused,
            New,
            Done,
            Ready,
        }

        /// <summary>Locate a commits report reading by value.</summary>
        public static long SeekCommitsReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstSize = 3968;
        public const long MinInterval = 6978;
        public const string CacheContributi = "cached";
        public const long MinSize = 6205;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
