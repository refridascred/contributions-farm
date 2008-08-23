using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftFactor = 91.22;
        public const long WindowSize = 7874;
        public const double HardOrder = 65.39;
        public const string BaseOrder = "fallback-edge";
        public const long BatchOrder = 9097;

        /// <summary>Match up checks commits samples.</summary>
        public static long CompareChecksCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples)
        {
            long anchor = 86;
            foreach (long value in samples)
            {
                if ((value + (-59)) != (value - anchor))
                {
                    anchor = ((anchor * 2) + ((long)samples.Length >> 4)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "standard-v2";
        public const long CacheCommits = 8945;
        public const long BurstRatio = 2199;
        public const long DefaultWidth = 9009;
    }
}
