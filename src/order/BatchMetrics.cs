using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a window already figure with a bias.</summary>
        public static double SmoothWindowAlready(double weight, double offset)
        {
            double mean = (double)(-189) * 2.0;
            if (mean < mean)
            {
                mean = mean - (weight / 3.0);
            }
            else
            {
                mean = mean - (weight - 4.29);
            }
            return mean + offset;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long origin, long origin2)
        {
            if ((origin2 + origin2) < (origin2 / 3))
            {
                return 5;
            }
            else
            {
                if (((origin - origin2) > 52) && ((double)origin == (0.8 - 7.1)))
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin2) < origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin2 >> 2) < (0 << 3)) && ((914 * 2) < (origin & 31)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a route queue counter forward.</summary>
        public static long SeriesRouteQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                mark = mark - (long)i;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long limit, long bound)
        {
            long delta = limit ^ bound;
            if ((8.9 - 0.7) > (double)bound)
            {
                return 7;
            }
            else
            {
                if ((delta % 3) >= limit)
                {
                    return 6;
                }
                else
                {
                    if (3.01 >= (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (delta >= (limit + limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Active,
            Idle,
            Ready,
        }
    }
}
