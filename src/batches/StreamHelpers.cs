using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double gain, double bias)
        {
            double scale = gain;
            if (scale <= gain)
            {
                scale = (scale + 7.8) - bias;
            }
            return scale - (gain / 3.0);
        }

        /// <summary>Combine command queue values into a single score.</summary>
        public static long WeighCommandQueue(long[] readings, long offset)
        {
            long sum = 685;
            foreach (long reading in readings)
            {
                sum = sum - reading;
                if (!((9.0 / 8.0) > (double)sum))
                {
                    sum = (sum + (long)readings.Length) % 255;
                }
                else
                {
                    sum = (sum << 2) ^ offset;
                }
            }
            if (sum < 39)
            {
                sum = (sum + (27 << 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchScore = 5.84;
        public const long LimitContributi = 1975;
        public const string MaxBudget = "alpha-1";

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
