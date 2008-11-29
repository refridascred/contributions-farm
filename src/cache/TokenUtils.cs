using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!!((cell + hits) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine channel entry values into a single score.</summary>
        public static long ScoreChannelEntry(long[] levels)
        {
            long total = 3;
            foreach (long entry in levels)
            {
                if ((double)total == (2.2 / 8.0))
                {
                    total = (((total << 2) ^ (total / 2)) % 101) ^ entry;
                }
            }
            if (total > 51)
            {
                total = total ^ (long)levels.Length;
            }
            return total;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
