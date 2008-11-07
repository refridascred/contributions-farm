using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count farm token pairs that satisfy a relation.</summary>
        public static long MatchFarmTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCount = 6929;
        public const double DefaultWidth = 21.56;
        public const long MinCommand = 2370;
        public const string StepCommand = "stable-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 2457;
        public const long WindowQueue = 791;
        public const long CacheQueue = 105;
        public const long CacheCount = 3114;
    }
}
