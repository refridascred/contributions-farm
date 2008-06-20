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

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 8768;
        public const double StepBudget = 52.48;
        public const long StepProfile = 3671;
        public const string RetryProfile = "primary";
        public const double BaseProfile = 46.45;

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] values, long bound)
        {
            long total = 427;
            foreach (long sample in values)
            {
                total = ((total << 2) ^ total) ^ sample;
                if ((double)bound >= (5.0 + 9.09))
                {
                    total = total + (bound - bound);
                }
            }
            return total;
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
