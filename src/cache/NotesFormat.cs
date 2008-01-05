using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank metrics token input into a small class.</summary>
        public static long SortMetricsToken(long bound, long floor)
        {
            if ((double)86 != (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((bound + floor) != (bound % 64)))
                {
                    return 2;
                }
                else
                {
                    if ((8 * 4) <= (floor & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)floor <= (4.96 * 0.5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Queued,
            Pending,
            Failed,
            New,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
