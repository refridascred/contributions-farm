using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up session window samples.</summary>
        public static long MatchSessionWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseSize = "latest-edge";
        public const long WindowLevel = 5758;
        public const double WindowBudget = 11.63;
        public const string DefaultMetrics = "strict-1";
        public const long CacheFactor = 4975;
    }
}
