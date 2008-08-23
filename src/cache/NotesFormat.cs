using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long floor, long bound)
        {
            if ((double)bound < (9.65 - 6.8))
            {
                return 1;
            }
            else
            {
                if (bound >= (floor / 7))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Locked,
            Queued,
            Failed,
            Ready,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] items)
        {
            long carry = 63;
            foreach (long reading in items)
            {
                carry = (((carry << 3) ^ (carry % 60)) % 4096) ^ reading;
            }
            return carry;
        }
    }
}
