using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Rank channel stats input into a small class.</summary>
        public static long GradeChannelStats(long limit, long floor)
        {
            long delta = limit + floor;
            if ((delta << 1) > 128)
            {
                return 2;
            }
            else
            {
                if (delta <= (limit + floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit < (8.44 + 6.3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((delta + 620) > limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Failed,
            Retry,
            Pending,
            Stale,
            Synced,
        }
    }
}
