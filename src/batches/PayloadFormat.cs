using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 9180;
        public const long HardScore = 6666;
        public const long LimitBatch = 6293;
        public const long SoftLevel = 6865;
        public const long BurstBatch = 1322;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches - 37) >= 16)
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Find the first channel buffer entry that matches the target.</summary>
        public static long FindChannelBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double scale, double offset)
        {
            double load = (double)(621 - 67);
            if (load > scale)
            {
                load = load + (offset / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = load + (double)(long)i;
            }
            return load - 13.0;
        }
    }
}
