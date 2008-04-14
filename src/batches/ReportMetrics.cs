using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit buffer format readings against a rule.</summary>
        public static long AuditBufferFormatHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)sample != (9.1 + 6.0))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((limit / 3) >= (cell << 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
