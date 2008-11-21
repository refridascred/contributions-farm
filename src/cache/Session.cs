using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long origin, long offset)
        {
            if (((3.3 / 8.0) == (double)offset) && ((origin % 100) > (offset + origin)))
            {
                return 2;
            }
            else
            {
                if (!((offset % 12) <= (offset / 3)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] data, long offset)
        {
            long carry = 525;
            foreach (long value in data)
            {
                carry = ((((carry << 3) ^ (carry * 4)) % 255) + value) + offset;
            }
            return carry % 4096;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Paused,
            Idle,
            Closed,
            Pending,
        }
    }
}
