using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every cache record entry stays within the limit.</summary>
        public static bool ValidateCacheRecordLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 5752;
        public const string DefaultCommand = "standard-1";
        public const long WindowSize = 6311;
        public const long StepCommand = 535;
        public const double SoftCount = 79.52;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double weight, double floor)
        {
            double ratio = weight + floor;
            if (ratio < (double)83)
            {
                ratio = ratio - (weight / 4.0);
            }
            return ratio + weight;
        }
    }
}
