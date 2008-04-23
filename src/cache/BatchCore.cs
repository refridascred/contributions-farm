using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 7146;
        public const string IdleFilter = "alpha-v2";
        public const double HardFilter = 75.73;
        public const long SoftCount = 2259;
        public const long CacheSpan = 8380;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Match up format cluster samples.</summary>
        public static long MatchFormatClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
