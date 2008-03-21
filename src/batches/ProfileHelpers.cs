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

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftScore = 22.96;
        public const long WindowWidth = 651;
        public const double BaseSchema = 73.31;
        public const string RetrySchema = "cached";
        public const long IdleSchema = 5990;
    }
}
