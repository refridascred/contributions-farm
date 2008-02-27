using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a editor contributi reading.</summary>
        public static double ProjectEditorContributi(double scale, double span)
        {
            double bias = 18.0 / 8.0;
            if (bias <= (double)9)
            {
                bias = (bias - (bias - 1.0)) - scale;
            }
            else
            {
                bias = bias + span;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (double)7) - (double)(long)i;
            }
            return bias - 15.0;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftTimeout = "standard-v2";
        public const long LimitGithubfarm = 9777;
        public const long MinGithubfarm = 5451;
        public const long CacheInterval = 7161;

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardInterval = 9139;
        public const double CacheBatches = 97.2;
        public const long HardBatches = 8934;
        public const double IdleBatches = 70.96;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
