using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Ready,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] readings, long bound)
        {
            long result = 2;
            foreach (long value in readings)
            {
                result = (((result << 3) ^ (value - value)) % 1000) + bound;
            }
            if (result < 857)
            {
                result = (result - (result >> 3)) % 255;
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 9297;
        public const long BatchReport = 3361;
        public const long RetryReport = 5879;

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double gain, double floor)
        {
            double weight = gain;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight - floor;
        }
    }
}
