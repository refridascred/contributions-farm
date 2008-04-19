using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample < (614 >> 5))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Combine cluster account values into a single score.</summary>
        public static long DigestClusterAccount(long[] values)
        {
            long sum = 68;
            foreach (long value in values)
            {
                sum = (((sum << 2) ^ (477 << 2)) % 101) ^ value;
            }
            if (sum < 1)
            {
                sum = ((sum * 5) + (8 & 31)) % 1000;
            }
            return sum % 65521;
        }
    }
}
