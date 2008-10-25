using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((datum - seen) >= (875 + seen)) && ((double)seen < (6.0 - 2.45)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Active,
            Ready,
            Done,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches >> 4) > (matches + matches))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long floor, long bound)
        {
            if ((3 + floor) < bound)
            {
                return 6;
            }
            else
            {
                if ((bound >> 3) < (floor * 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor < 3.0)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)floor != (10.0 + 4.4)) || ((bound >> 3) > (bound / 8)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first order route entry that matches the target.</summary>
        public static long SeekOrderRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
