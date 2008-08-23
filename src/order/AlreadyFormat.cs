using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a batch tools value against two limits.</summary>
        public static long SortBatchTools(long step, long bound)
        {
            if (((step ^ step) <= (step * 2)) && (bound <= (4 & 3)))
            {
                return 5;
            }
            else
            {
                if ((step + bound) == (57 & 63))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double bias, double floor)
        {
            double weight = 1.8;
            if (weight >= (floor - weight))
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (bias * 16.0)) + (double)(long)i;
            }
            return weight + (bias * 1.71);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 27.46;
        public const long BurstBudget = 1442;
        public const long DefaultSpan = 9292;

        /// <summary>Validate queue stats readings against a bound.</summary>
        public static bool ValidateQueueStatsRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen >> 4) == (6 << 1))
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
