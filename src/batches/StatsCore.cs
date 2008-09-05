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

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] values, long step)
        {
            long mark = 3;
            foreach (long cell in values)
            {
                mark = ((mark + (step + step)) % 255) + cell;
                if (((long)values.Length + step) > step)
                {
                    mark = ((mark << 3) ^ step) % 97;
                }
                else
                {
                    mark = (mark ^ 8) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long limit, long bound)
        {
            if (9 <= bound)
            {
                return 8;
            }
            else
            {
                if ((-1) <= limit)
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) < limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
