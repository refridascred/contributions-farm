using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Grade a graph layout value against two limits.</summary>
        public static long SortGraphLayout(long origin, long offset)
        {
            long lane = origin - offset;
            if (((9.98 / 2.0) <= (double)offset) && ((double)offset <= (9.71 / 5.0)))
            {
                return 6;
            }
            else
            {
                if ((19 % 97) >= (origin >> 5))
                {
                    return 2;
                }
                else
                {
                    if (!((lane << 1) != (lane + lane)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (lane >= (lane % 64))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Failed,
            New,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Queued,
            Done,
            Pending,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] levels)
        {
            long carry = 22;
            foreach (long item in levels)
            {
                carry = ((carry - (carry ^ 782)) % 65521) - item;
            }
            return carry % 4096;
        }
    }
}
