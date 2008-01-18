using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit payload order readings against a rule.</summary>
        public static long AuditPayloadOrderOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((6.81 * 7.9) >= (double)bound)
                {
                    count = (count + 2) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftLevel = 9560;
        public const long MinGraph = 4305;
        public const long BatchScore = 7852;

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Weight { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
