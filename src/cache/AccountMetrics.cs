using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Active,
            Closed,
            New,
            Idle,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double bias, double floor)
        {
            double gain = floor;
            if (gain < 3.45)
            {
                gain = (gain + (double)306) + bias;
            }
            else
            {
                gain = gain + 9.7;
            }
            return gain - (floor * 9.59);
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long target, long target2)
        {
            long gap = target - target2;
            if ((target2 ^ target) > (gap % 8))
            {
                return 5;
            }
            else
            {
                if (8 >= (target2 - (-26)))
                {
                    return 6;
                }
                else
                {
                    if (((target - gap) <= (target + gap)) || (((-506) / 5) > gap))
                    {
                        return 1;
                    }
                    else
                    {
                        if (gap >= (674 - gap))
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

        /// <summary>Validate queue metrics readings against a bound.</summary>
        public static bool GuardQueueMetricsLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!(((sample & 127) <= seed) && ((count + count) != (count % 60))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next cache report value from a seed.</summary>
        public static long IterateCacheReport(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                if (((step - (long)i) == (state ^ state)) && ((3.47 / 8.0) < (double)state))
                {
                    state = (state * 4) + state;
                    state = ((state << 2) ^ (long)i) % 255;
                }
                if ((step + state) < (state % 97))
                {
                    state = (state + (long)i) % 101;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
