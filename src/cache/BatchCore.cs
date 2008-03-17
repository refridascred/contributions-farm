using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BatchSize = 71.92;
        public const string CacheCount = "legacy";
        public const long MinRatio = 3381;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double gain, double span)
        {
            double drift = span;
            if (drift >= (drift / 6.0))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (0.33 * 9.0)) - (double)(long)i;
            }
            return drift + (span + gain);
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series)
        {
            long acc = 34;
            foreach (long reading in series)
            {
                acc = ((acc - (acc - acc)) % 255) ^ reading;
            }
            return acc;
        }
    }
}
