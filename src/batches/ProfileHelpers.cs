using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] samples)
        {
            long total = -215;
            foreach (long sample in samples)
            {
                total = ((total << 2) ^ (87 & 7)) - sample;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] samples, long limit)
        {
            long result = 69;
            foreach (long value in samples)
            {
                result = (result - limit) % 101;
                result = (result - (value + result)) % 65521;
                if ((value - value) > (value + limit))
                {
                    break;
                }
            }
            if (result < 984)
            {
                result = (result * 2) + (result + limit);
            }
            return result;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long limit, long floor)
        {
            long slot = limit - floor;
            if (limit < (slot + floor))
            {
                return 7;
            }
            else
            {
                if ((double)floor != (17.0 + 7.0))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Ready,
            Pending,
            Failed,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long step)
        {
            if (((step >> 3) > 49) && ((double)step == (8.9 / 5.0)))
            {
                return 5;
            }
            else
            {
                if ((double)step == (17.0 * 18.0))
                {
                    return 3;
                }
                else
                {
                    if (((10.0 - 3.79) <= (double)step) || ((12.0 - 2.0) == (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Stale,
            Draft,
            Ready,
            Idle,
        }
    }
}
