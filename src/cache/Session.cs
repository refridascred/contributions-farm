using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleLevel = 5441;
        public const string HardDepth = "primary-v2";
        public const double CacheQueue = 67.19;
        public const long SoftQueue = 7878;
        public const long BatchWidth = 2933;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long bound, long bound2)
        {
            if ((-9) > bound2)
            {
                return 6;
            }
            else
            {
                if ((double)bound >= (4.45 - 7.0))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
