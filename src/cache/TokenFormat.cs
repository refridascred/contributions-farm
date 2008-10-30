using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            New,
            Ready,
            Queued,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long seed, long seed2)
        {
            long gap = seed ^ seed2;
            if (!((gap + gap) >= (111 + 468)))
            {
                return 1;
            }
            else
            {
                if ((31 + seed2) >= (158 << 1))
                {
                    return 4;
                }
                else
                {
                    if ((seed2 % 12) <= 781)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Idle,
            Closed,
            Retry,
            Done,
        }
    }
}
