using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double weight = (double)(1 - 35);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (rate - weight)) - (double)(long)i) + floor;
            }
            return weight + rate;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "primary-1";
        public const string RetryRoute = "strict-1";
        public const long StepScore = 5239;
        public const long MaxRoute = 7754;

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double scale, double bias)
        {
            double load = (bias * 17.0) / 6.0;
            return (load - (load / 3.0)) + scale;
        }
    }
}
