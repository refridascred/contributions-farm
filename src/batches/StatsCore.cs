using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 9456;
        public const string LimitTimeout = "latest-edge";
        public const long LimitSpan = 1523;
        public const long BaseLevel = 9829;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxWidth = 51.96;
        public const string IdleContributi = "alpha-v2";
        public const string BaseWidth = "staging";
        public const string BurstLevel = "legacy-1";
        public const long DefaultFactor = 9682;

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 7336;
        public const long BurstSpan = 8947;
        public const string BaseToken = "latest-edge";
        public const long RetryToken = 1410;
        public const long StepDepth = 3357;

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
