using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Draft,
            Closed,
            New,
            Idle,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((step > tally) || (tally <= (44 % 100))) && ((double)(long)values.Length > 6.25))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
