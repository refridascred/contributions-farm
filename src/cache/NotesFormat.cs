using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings, long origin)
        {
            long result = 137;
            foreach (long datum in readings)
            {
                result = (((result + result) % 4096) ^ datum) - origin;
            }
            return result;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long origin)
        {
            long slot = bound - origin;
            if ((double)bound < (9.0 - 1.0))
            {
                return 3;
            }
            else
            {
                if (slot < bound)
                {
                    return 1;
                }
                else
                {
                    if ((927 & 15) < (origin - 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)(-272) <= (double)origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
