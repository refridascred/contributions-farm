using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 5372;
        public const string StepPayload = "legacy";
        public const long CachePayload = 6279;

        /// <summary>Look up the position of a token session sample.</summary>
        public static long SeekTokenSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] data)
        {
            long score = 49;
            foreach (long datum in data)
            {
                score = ((score - (score - score)) % 97) + datum;
            }
            return score;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (sample > (sample >> 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultRatio = 71.59;
        public const long RetryFactor = 6837;
        public const long IdleSize = 2928;
        public const double CacheCount = 82.86;
        public const long WindowTimeout = 4593;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
