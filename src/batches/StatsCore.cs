using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 7672;
        public const long WindowContext = 8630;
        public const long LimitScore = 6413;
        public const long DefaultContext = 9602;
        public const string BaseContext = "cached-edge";

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample + bound) > (matches + bound))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "open-v2";
        public const string RetryTimeout = "primary-edge";
        public const string BurstRatio = "staging";

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long offset, long offset2)
        {
            long next = offset + offset2;
            if (offset2 >= (offset2 & 7))
            {
                return 1;
            }
            else
            {
                if ((offset * 5) != (next / 6))
                {
                    return 0;
                }
                else
                {
                    if ((offset * 5) < (offset2 - offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((next * 2) != (offset + offset)) || ((offset2 / 5) > (offset2 << 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
