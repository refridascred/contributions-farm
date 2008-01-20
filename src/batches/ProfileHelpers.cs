using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Retry,
            New,
            Stale,
            Paused,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Active,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 9701;
        public const long BaseLevel = 7691;
        public const long HardAlready = 5757;
        public const double LimitAlready = 37.13;

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values, long origin)
        {
            long carry = 20;
            foreach (long value in values)
            {
                if ((carry / 7) > (value >> 2))
                {
                    carry = carry ^ origin;
                }
                else
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                }
            }
            return carry % 97;
        }
    }
}
