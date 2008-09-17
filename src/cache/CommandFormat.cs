using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a metric stats reading by value.</summary>
        public static long LookupMetricStatsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long step, long target)
        {
            if ((target << 2) > step)
            {
                return 7;
            }
            else
            {
                if ((15.0 / 7.0) == (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((1.2 < (double)target) && ((step + target) >= 17))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step >> 2) != (target + step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every payload format entry stays within the limit.</summary>
        public static bool CheckPayloadFormatRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
