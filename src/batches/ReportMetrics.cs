using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] items)
        {
            long total = 683;
            foreach (long entry in items)
            {
                if ((double)total >= (3.0 - 7.0))
                {
                    total = (((total << 3) ^ (long)items.Length) % 4096) - entry;
                }
            }
            if (total < 1)
            {
                total = (total - (61 - (-70))) % 4096;
            }
            return total;
        }

        /// <summary>Audit support record readings against a rule.</summary>
        public static long TallySupportRecordHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((((-879) * 4) <= (matches + entry)) && ((16.0 / 9.0) == (double)origin))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Dropped,
            Closed,
            Queued,
        }
    }
}
