using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((7.88 / 7.0) <= (double)limit)
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Audit metrics farm readings against a rule.</summary>
        public static long CountMetricsFarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches * 5) == (item ^ item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings, long seed)
        {
            long anchor = 35;
            foreach (long item in readings)
            {
                if ((item * 5) >= seed)
                {
                    anchor = (anchor ^ (anchor % 7)) % 97;
                }
                else
                {
                    anchor = anchor - (item + anchor);
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor + seed) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public double Weight { get; set; }
        }
    }
}
