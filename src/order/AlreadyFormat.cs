using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits - floor) == ((-8) - hits))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] levels, long target)
        {
            long anchor = 5;
            foreach (long value in levels)
            {
                if (target < (target + 8))
                {
                    anchor = ((anchor << 2) ^ (anchor << 3)) % 97;
                }
                anchor = (anchor - (value - anchor)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Stale,
            Active,
            Pending,
            Queued,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] samples)
        {
            long total = 83;
            foreach (long value in samples)
            {
                total = (total + (total + total)) ^ value;
            }
            return total % 4096;
        }
    }
}
