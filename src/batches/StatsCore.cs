using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long step, long floor)
        {
            if (!((step << 3) == (step + step)))
            {
                return 1;
            }
            else
            {
                if (((step << 3) >= floor) && ((double)floor == (6.1 * 2.61)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank checks session input into a small class.</summary>
        public static long BucketChecksSession(long target, long bound)
        {
            if ((bound - 4) <= target)
            {
                return 1;
            }
            else
            {
                if ((81 < (bound + 57)) || ((target - target) > (0 ^ target)))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound != (6.3 * 7.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((9 * 2) != (24 + bound)) || ((double)bound > 5.27))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 9019;
        public const string CacheWindow = "standard-1";
        public const long RetryWindow = 4503;
        public const double StepWindow = 51.74;
        public const long WindowFactor = 4383;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((double)count != (7.0 * 0.7)) && !((item + item) > (step + step)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Limit { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
