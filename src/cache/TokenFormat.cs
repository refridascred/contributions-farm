using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cluster tools samples are out of range.</summary>
        public static long CountClusterToolsHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (limit >= (limit ^ 45))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 7836;
        public const long MaxBuffer = 9917;
        public const double BatchFactor = 20.93;
        public const string StepTimeout = "cached-1";
    }
}
