using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "alpha-edge";
        public const long BatchTools = 7761;
        public const string DefaultTools = "local-1";

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 47.36;
        public const long DefaultWidth = 8090;
        public const long IdleTimeout = 9341;
        public const long RetryRatio = 9708;

        /// <summary>Find the first farm format entry that matches the target.</summary>
        public static long SeekFarmFormatIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 5) >= datum)
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }
    }
}
