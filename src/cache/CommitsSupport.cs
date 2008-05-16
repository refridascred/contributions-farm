using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double bias, double span)
        {
            double rate = span;
            if (rate > 7.3)
            {
                rate = (rate - (5.5 / 9.0)) - bias;
            }
            else
            {
                rate = rate - (7.7 + span);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long floor, long bound)
        {
            long step = floor - bound;
            if ((step << 2) > (step * 2))
            {
                return 0;
            }
            else
            {
                if ((double)floor <= (4.75 / 7.0))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Paused,
            Closed,
            Retry,
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate session buffer readings against a bound.</summary>
        public static bool ValidateSessionBufferBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
