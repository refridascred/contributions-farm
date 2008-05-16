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

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long floor, long origin)
        {
            if ((56 + floor) > origin)
            {
                return 7;
            }
            else
            {
                if ((origin & 15) <= floor)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
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
