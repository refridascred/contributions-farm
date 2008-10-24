using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long bound, long floor)
        {
            long span = bound - floor;
            if ((double)span > (4.6 - 2.9))
            {
                return 6;
            }
            else
            {
                if (bound > (span ^ span))
                {
                    return 4;
                }
                else
                {
                    if (((span + bound) > floor) && ((double)floor <= (20.0 + 11.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (datum > (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long offset)
        {
            if (12.0 >= (double)step)
            {
                return 6;
            }
            else
            {
                if (((offset - 729) > (step * 5)) && ((offset >> 2) <= (step + step)))
                {
                    return 1;
                }
                else
                {
                    if (!((offset >> 2) == (offset % 10)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset > (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double floor)
        {
            double rate = (bias * 9.6) - (3.75 / 9.0);
            if (rate < (floor + bias))
            {
                rate = rate + bias;
            }
            return rate + (5.78 + bias);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 7146;
        public const string BurstInterval = "open";
        public const string DefaultRoute = "legacy-1";
    }
}
