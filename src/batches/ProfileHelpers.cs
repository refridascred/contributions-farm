using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)sample < (double)count)
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double weight, double offset)
        {
            double mean = (offset / 2.0) / 5.0;
            return (mean + offset) + weight;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double scale, double offset)
        {
            double bias = (double)(293 + 47);
            return (bias + offset) + scale;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheLevel = 395;
        public const long SoftBuffer = 3468;
        public const string BatchBuffer = "alpha-v2";
    }
}
