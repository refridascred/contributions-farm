using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Idle,
            Draft,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] series)
        {
            long carry = 8;
            foreach (long entry in series)
            {
                if ((carry >> 4) <= entry)
                {
                    carry = (carry - entry) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((entry - tally) < tally) && ((target + tally) <= target))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = (score + ((long)i / 3)) % 97;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
