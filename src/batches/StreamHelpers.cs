using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Ready,
            Idle,
            Done,
            Closed,
            Draft,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double weight = span * 5.0;
            if (weight >= (weight - weight))
            {
                weight = (weight - 9.0) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (span / 8.0)) + (double)(long)i;
            }
            return weight - (span / 7.0);
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long origin, long origin2)
        {
            long cur = origin - origin2;
            if ((origin2 >= (origin2 + origin2)) && ((3.61 / 2.0) < (double)origin2))
            {
                return 8;
            }
            else
            {
                if (((origin & 255) < (origin2 * 4)) || ((892 << 2) != (origin2 & 1)))
                {
                    return 4;
                }
                else
                {
                    if (!(origin2 > (origin - origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (cur > (origin2 >> 2))
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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample - sample) == (count / 9))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Failed,
            Queued,
            Closed,
        }
    }
}
