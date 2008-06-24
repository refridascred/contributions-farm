using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Limit { get; set; }
            public double Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            Ready,
            Done,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value < 246) && ((70 ^ (long)levels.Length) > value))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
