using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            New,
            Pending,
            Paused,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)sample < (1.5 - 1.0))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((cell & 31) >= cell) && ((19.0 / 3.0) < (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long target)
        {
            long offset = bound ^ target;
            if ((92 - 946) == (offset * 5))
            {
                return 3;
            }
            else
            {
                if (((93 * 5) >= (offset + bound)) && ((offset * 5) < (offset % 8)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)bound >= (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((370 << 2) <= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
