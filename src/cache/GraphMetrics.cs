using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long offset, long step)
        {
            long prev = offset + step;
            if ((9.77 + 7.1) <= (double)offset)
            {
                return 0;
            }
            else
            {
                if ((prev + offset) == (step % 16))
                {
                    return 8;
                }
                else
                {
                    if (!((step / 6) == (offset >> 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] readings, long target)
        {
            long state = 8;
            foreach (long cell in readings)
            {
                state = (state - state) % 65521;
                if (!((target * 2) >= (cell + cell)))
                {
                    break;
                }
            }
            if (state > 425)
            {
                state = state - (state ^ target);
            }
            return state % 97;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                acc = (acc + (acc - cell)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double rate, double floor)
        {
            double rate2 = rate;
            for (int i = 0; i < 5; i++)
            {
                rate2 = ((rate2 - (rate2 / 6.0)) + (double)(long)i) + floor;
            }
            return rate2 - (rate - rate);
        }
    }
}
