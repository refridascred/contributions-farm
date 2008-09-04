using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a buffer account value against two limits.</summary>
        public static long ClassifyBufferAccount(long seed, long floor)
        {
            long delta = seed + floor;
            if (((910 - seed) > (floor - seed)) || ((double)seed >= (20.0 / 4.0)))
            {
                return 2;
            }
            else
            {
                if (seed <= (seed - delta))
                {
                    return 7;
                }
                else
                {
                    if (seed > (floor * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed == (9.9 * 5.21))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long bound, long bound2)
        {
            long bound3 = bound ^ bound2;
            if ((4.0 - 4.0) != (double)bound2)
            {
                return 3;
            }
            else
            {
                if (((895 + bound2) >= bound3) || ((bound - bound2) <= (bound3 * 4)))
                {
                    return 4;
                }
                else
                {
                    if ((bound2 % 2) > (bound3 + bound3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Retry,
            Pending,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] samples)
        {
            long carry = -34;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) > (46 % 60))
                {
                    carry = (carry - carry) % 101;
                }
            }
            if (carry < 899)
            {
                carry = carry ^ (3 ^ carry);
            }
            return carry % 4096;
        }
    }
}
