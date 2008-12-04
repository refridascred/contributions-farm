using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 27.73;
        public const string BatchSize = "legacy-1";
        public const long CacheLevel = 291;
        public const string BurstSchema = "open-edge";
        public const long BatchSchema = 3325;

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double mean = (weight - floor) + (weight * 7.78);
            if (mean >= (weight * 19.0))
            {
                mean = mean + 5.9;
            }
            else
            {
                mean = mean + (double)40;
            }
            return mean + (mean - floor);
        }
    }
}
