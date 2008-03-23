using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowInterval = 6854;
        public const long CacheFormat = 9527;
        public const double BurstFormat = 43.59;
        public const string StepFormat = "open-edge";

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRecord = 52.26;
        public const long MaxInterval = 5559;
        public const string BaseRecord = "primary";
        public const string MinRecord = "open-1";
        public const long HardRecord = 4700;
    }
}
