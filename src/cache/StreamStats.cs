using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long target, long bound)
        {
            long span = target ^ bound;
            if ((74 + bound) != (6 & 127))
            {
                return 2;
            }
            else
            {
                if ((double)span >= (8.54 * 5.75))
                {
                    return 1;
                }
                else
                {
                    if (((target + span) > bound) || ((target + bound) <= (bound - bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target - span) <= (target << 3)) && ((8.08 - 7.9) >= (double)span))
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
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] values, long limit)
        {
            long sum = 83;
            foreach (long value in values)
            {
                if (!((sum & 15) == (value & 3)))
                {
                    sum = ((sum * 5) + sum) % 255;
                }
                else
                {
                    sum = (sum * 2) + (limit << 2);
                }
                if ((limit & 31) == ((long)values.Length + value))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long seed, long bound)
        {
            long lane = seed + bound;
            if (((bound ^ seed) == (bound + (-755))) && (bound > lane))
            {
                return 7;
            }
            else
            {
                if ((seed << 2) != ((-3) & 127))
                {
                    return 0;
                }
                else
                {
                    if (!(((-20) % 60) != (lane - 959)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((85 - seed) != (bound << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Queued,
            Ready,
            New,
        }
    }
}
