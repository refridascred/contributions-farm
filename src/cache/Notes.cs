using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - count) != (reading << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < (3.0 + 3.37))
                {
                    matches = (matches + 1) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public double Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Classify a counter contributi pair into a bucket.</summary>
        public static long SortCounterContributi(long bound, long bound2)
        {
            long lane = bound - bound2;
            if ((double)lane != (7.8 + 2.2))
            {
                return 3;
            }
            else
            {
                if ((double)bound2 != (9.0 * 5.25))
                {
                    return 5;
                }
                else
                {
                    if (!((bound2 & 7) >= (bound2 & 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)2 < (double)bound)
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

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Stale,
            Closed,
            Done,
            Failed,
        }
    }
}
