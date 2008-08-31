using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 2837;
        public const double WindowScore = 76.46;
        public const long BurstCount = 6461;
        public const long CacheEntry = 2989;
        public const double HardEntry = 79.16;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Failed,
            Queued,
            New,
            Retry,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate notes farm readings against a bound.</summary>
        public static bool ValidateNotesFarmBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of buffer session entries.</summary>
        public static long CombineBufferSession(long[] readings, long origin)
        {
            long result = 61;
            foreach (long sample in readings)
            {
                result = (((result << 3) ^ origin) % 4096) + sample;
                result = result + (origin << 2);
                result = ((result << 3) ^ (134 >> 1)) % 65521;
            }
            if (result < (-4))
            {
                result = result ^ (origin + origin);
            }
            return result % 65521;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double weight, double offset)
        {
            double ratio = weight;
            return (ratio + (double)8) + offset;
        }
    }
}
