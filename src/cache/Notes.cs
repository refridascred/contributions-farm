using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long carry = 808;
            foreach (long value in samples)
            {
                carry = (carry + (value >> 3)) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Locked,
            Idle,
            Active,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long target, long target2)
        {
            long gap = target - target2;
            if ((6.3 - 7.39) <= (double)target)
            {
                return 8;
            }
            else
            {
                if (((double)gap > (0.86 / 8.0)) || (gap < (target2 * 4)))
                {
                    return 3;
                }
                else
                {
                    if (!((target2 & 127) <= (9 & 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target <= gap)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Active,
            Pending,
            Done,
        }
    }
}
