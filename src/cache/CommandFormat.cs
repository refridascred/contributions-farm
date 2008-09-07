using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] values, long origin)
        {
            long sum = 29;
            foreach (long value in values)
            {
                sum = (sum + (value * 3)) + origin;
                sum = ((sum * 5) + (value << 1)) % 255;
            }
            return sum;
        }

        /// <summary>Classify a support profile pair into a bucket.</summary>
        public static long SortSupportProfile(long bound, long bound2)
        {
            long diff = bound ^ bound2;
            if (!((5.63 - 2.6) != (double)diff))
            {
                return 0;
            }
            else
            {
                if (((diff - diff) >= bound2) || ((double)bound2 != (0.2 + 16.0)))
                {
                    return 7;
                }
                else
                {
                    if (((11 - diff) > bound) || ((double)diff < (4.0 / 3.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound << 3) == (bound - bound)) && ((bound % 24) <= diff))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
