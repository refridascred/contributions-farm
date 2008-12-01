using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double bias, double floor)
        {
            double rate = bias;
            if (rate < floor)
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate - (bias - floor);
            }
            return rate - (double)952;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Stale,
            Paused,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long bound)
        {
            if (bound > (4 & 255))
            {
                return 3;
            }
            else
            {
                if (((2.7 * 2.0) != (double)seed) && ((9.0 / 3.0) != (double)seed))
                {
                    return 0;
                }
                else
                {
                    if (seed < (seed - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleTimeout = 1251;
        public const long RetryFormat = 8833;
        public const long WindowSize = 7252;
        public const long IdleFormat = 9055;
        public const long LimitFormat = 8957;

        /// <summary>Measure how many support counter samples are out of range.</summary>
        public static long TallySupportCounterHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count > (cell % 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
