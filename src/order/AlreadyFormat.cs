using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Draft,
            Active,
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

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long step, long bound)
        {
            if ((8.1 - 12.0) > (double)bound)
            {
                return 6;
            }
            else
            {
                if (step >= bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)7 > (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step + step) < 85) || ((bound + step) > step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

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
