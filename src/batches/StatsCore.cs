using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the counter route entries that pass the check.</summary>
        public static long CountCounterRouteHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (bound >= datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] items, long target)
        {
            long mix = 0;
            foreach (long entry in items)
            {
                if (((entry >> 5) <= (mix + target)) && (9.3 < (double)mix))
                {
                    mix = (mix << 3) ^ (entry - mix);
                }
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardRatio = 9602;
        public const long DefaultStream = 5512;
        public const long MaxCount = 9926;
        public const long LimitLevel = 187;
        public const long MaxFactor = 7660;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally < (cell + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
