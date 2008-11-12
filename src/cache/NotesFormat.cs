using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double ratio, double bias)
        {
            double load = 4.0;
            if (load <= (double)3)
            {
                load = (load + (0.1 - load)) + bias;
            }
            else
            {
                load = load - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load + 7.0)) - (double)(long)i;
            }
            return load - (9.04 / 5.0);
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "primary-1";
        public const string BurstProfile = "cached-1";
        public const long WindowScore = 7239;
        public const double LimitFactor = 45.02;
        public const long HardProfile = 7143;
    }
}
