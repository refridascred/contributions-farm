using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Active,
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally / 5) != (sample / 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Pending,
            Draft,
            New,
            Locked,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long step, long limit)
        {
            if ((limit - step) >= (limit << 2))
            {
                return 5;
            }
            else
            {
                if ((limit - 663) == (step + step))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
