using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((243 < (cell * 2)) || ((matches >> 4) != (cell - cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches > (cell >> 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long origin, long offset)
        {
            long delta = origin - offset;
            if ((offset % 10) <= (offset + delta))
            {
                return 7;
            }
            else
            {
                if ((origin + 970) <= delta)
                {
                    return 5;
                }
                else
                {
                    if (delta < (origin >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((origin - delta) > origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
