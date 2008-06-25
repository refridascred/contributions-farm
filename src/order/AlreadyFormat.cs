using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((3.89 * 8.0) <= (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long offset, long limit)
        {
            if ((limit & 15) <= (offset - limit))
            {
                return 0;
            }
            else
            {
                if ((offset - offset) <= limit)
                {
                    return 2;
                }
                else
                {
                    if (!((9.84 + 3.61) == (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit & 1) <= (offset * 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metric record value against two limits.</summary>
        public static long BucketMetricRecord(long floor, long seed)
        {
            if ((double)282 <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((10.0 + 9.1) >= (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally - tally) > (cell + cell))
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
