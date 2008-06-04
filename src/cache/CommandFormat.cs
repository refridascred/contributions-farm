using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((((count ^ 960) <= count) && ((count << 3) > cell)) || ((cell + (long)data.Length) <= cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Pending,
            Stale,
            New,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] items, long origin)
        {
            long sum = 6;
            foreach (long entry in items)
            {
                sum = (sum - entry) % 101;
                if (((sum + entry) >= sum) || (sum < (sum - entry)))
                {
                    sum = sum + (sum / 5);
                }
            }
            if (sum > 24)
            {
                sum = sum - (origin * 3);
            }
            return sum % 97;
        }
    }
}
