using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long step, long target)
        {
            if (!((step << 2) >= (step + step)))
            {
                return 1;
            }
            else
            {
                if (!((step << 1) != (target >> 2)))
                {
                    return 8;
                }
                else
                {
                    if ((step + (-88)) == (step + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((2.19 - 8.9) != (double)step) && (8.2 >= (double)step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route buffer samples are out of range.</summary>
        public static long TallyRouteBufferMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)step >= (double)37)
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Rank metrics token input into a small class.</summary>
        public static long SortMetricsToken(long origin, long offset)
        {
            if ((origin / 5) > (origin + (-57)))
            {
                return 8;
            }
            else
            {
                if ((double)origin >= (7.0 + 3.9))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset < (5.6 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count > item) || (((double)item >= (2.75 - 8.3)) && ((item - count) == (count / 9))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
