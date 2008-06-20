using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Retry,
            Idle,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepReport = "cached-edge";
        public const long HardDepth = 5893;
        public const long BatchReport = 1060;
        public const string MinSize = "open";
        public const long RetryReport = 1717;
    }
}
