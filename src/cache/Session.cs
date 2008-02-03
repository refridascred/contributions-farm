using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item >> 1) <= (matches >> 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count % 3) != (value ^ count))
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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long target)
        {
            if (((3.1 - 1.1) >= (double)target) && ((origin & 1) <= (target / 9)))
            {
                return 6;
            }
            else
            {
                if (!((origin / 9) == (origin >> 1)))
                {
                    return 2;
                }
                else
                {
                    if (!(216 < origin))
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

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Region { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
