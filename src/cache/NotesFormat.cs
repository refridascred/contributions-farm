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

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] values)
        {
            long result = 9;
            foreach (long sample in values)
            {
                result = ((result * 5) + (sample + sample)) % 65521;
            }
            return result;
        }
    }
}
