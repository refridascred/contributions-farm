using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count notes channel pairs that satisfy a relation.</summary>
        public static long CompareNotesChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 7098;
        public const long CacheTimeout = 429;
        public const double MinTools = 79.47;
        public const string RetryTools = "latest-v2";

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Total { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
