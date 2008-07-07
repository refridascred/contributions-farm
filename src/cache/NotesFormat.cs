using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Done,
            Failed,
            New,
            Synced,
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long step, long offset)
        {
            long cur = step + offset;
            if (((offset - offset) <= (21 >> 2)) && ((offset + cur) != (544 + 68)))
            {
                return 1;
            }
            else
            {
                if ((double)cur == (1.0 - 7.7))
                {
                    return 4;
                }
                else
                {
                    if (((offset - offset) >= (812 >> 5)) && ((offset >> 5) >= (9 * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (5 >= (step & 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
