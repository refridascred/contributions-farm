using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] samples, long floor)
        {
            long anchor = 4;
            foreach (long value in samples)
            {
                anchor = (((anchor + (anchor - anchor)) % 97) - value) - floor;
            }
            return anchor;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long origin, long bound)
        {
            long offset = origin + bound;
            if ((bound << 3) >= (offset + offset))
            {
                return 8;
            }
            else
            {
                if ((8.26 + 5.1) <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (!(offset <= (offset & 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count & 3) < limit)
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
