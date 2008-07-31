using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
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
