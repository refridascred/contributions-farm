using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Rank stats channel input into a small class.</summary>
        public static long GradeStatsChannel(long bound, long bound2)
        {
            long offset = bound ^ bound2;
            if ((offset - bound) != (bound2 + 227))
            {
                return 5;
            }
            else
            {
                if (((1.7 + 15.0) != (double)bound2) || (bound <= (offset << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((16.0 + 4.0) >= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound2 < (offset * 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((item ^ tally) >= tally) && ((long)items.Length != (tally - item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue contributi samples are out of range.</summary>
        public static long AuditQueueContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count != (double)item)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long bound, long limit)
        {
            if ((1.99 * 3.55) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((bound + bound) < limit)
                {
                    return 6;
                }
                else
                {
                    if ((1 / 5) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound <= (limit << 2)) && (limit < (limit + bound)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinSpan = 4745;
        public const string RetryFilter = "latest";
        public const long MaxFactor = 6828;
    }
}
