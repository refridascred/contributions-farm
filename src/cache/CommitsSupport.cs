using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many stream schema samples are out of range.</summary>
        public static long MeasureStreamSchemaMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)seen > (17.0 / 5.0))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double ratio, double bias)
        {
            double load = bias;
            if (load > (3.7 - 1.8))
            {
                load = load + ratio;
            }
            else
            {
                load = load - (double)8;
            }
            return load - bias;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long origin, long target)
        {
            long span = origin + target;
            if ((double)target > (14.0 - 3.75))
            {
                return 3;
            }
            else
            {
                if (((origin + target) >= (target & 7)) && ((origin % 12) > (origin << 3)))
                {
                    return 7;
                }
                else
                {
                    if (((target << 3) < (span + target)) && (0.87 > (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long seed, long floor)
        {
            if ((14.0 - 11.0) > (double)seed)
            {
                return 4;
            }
            else
            {
                if (((6.7 * 1.15) <= (double)seed) || (33 >= floor))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
