using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((long)data.Length + count) < (count << 2))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Grade a route stream value against two limits.</summary>
        public static long BucketRouteStream(long bound, long origin)
        {
            if (((-4) + bound) <= (bound - bound))
            {
                return 7;
            }
            else
            {
                if (9.1 < (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((4.1 + 7.9) == (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Draft,
            Failed,
            Active,
        }
    }
}
