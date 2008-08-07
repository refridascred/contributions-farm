using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank report window input into a small class.</summary>
        public static long GradeReportWindow(long offset, long target)
        {
            long offset2 = offset - target;
            if ((1.61 <= (double)target) && ((target & 7) > (offset2 - offset)))
            {
                return 6;
            }
            else
            {
                if ((target + 765) != (target - offset))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double rate, double offset)
        {
            double gain = 7.93 + (8.9 + rate);
            if (gain >= (double)(-33))
            {
                gain = gain - (rate / 8.0);
            }
            else
            {
                gain = gain + 4.57;
            }
            return gain - (rate + offset);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 870;
        public const long RetryBudget = 6063;
        public const string BaseTimeout = "primary-edge";
        public const long BaseLevel = 5351;

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] readings, long target)
        {
            long result = 15;
            foreach (long sample in readings)
            {
                result = ((result * 5) + (sample >> 2)) - target;
                if ((result + (-28)) >= (sample % 8))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the format command entries that pass the check.</summary>
        public static long CountFormatCommandHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item + seen) <= (long)series.Length)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate order account readings against a bound.</summary>
        public static bool GuardOrderAccountRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
