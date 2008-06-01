using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 7224;
        public const long StepCount = 427;
        public const long DefaultCache = 604;
        public const double LimitCache = 44.11;
        public const double LimitCount = 77.66;

        /// <summary>Find the first payload batch entry that matches the target.</summary>
        public static long FindPayloadBatchIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the counter cluster series from a seed.</summary>
        public static long SeriesCounterCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((double)bound == (1.3 - 5.04))
                {
                    score = score - (bound & 255);
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepInterval = 8303;
        public const double IdleCounter = 79.48;
        public const string SoftTimeout = "staging";
    }
}
