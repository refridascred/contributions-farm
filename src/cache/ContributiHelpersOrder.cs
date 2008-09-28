using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Queued,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long seed, long seed2)
        {
            if (!((double)seed2 <= (4.0 - 8.6)))
            {
                return 8;
            }
            else
            {
                if ((seed2 ^ seed) < (seed * 5))
                {
                    return 1;
                }
                else
                {
                    if ((seed < (4 - seed2)) || ((seed2 * 2) >= 231))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((seed2 - seed) > seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
