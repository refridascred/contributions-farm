using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long origin, long limit)
        {
            long cur = origin - limit;
            if ((double)3 <= (double)cur)
            {
                return 4;
            }
            else
            {
                if ((1.45 - 0.2) < (double)origin)
                {
                    return 7;
                }
                else
                {
                    if ((origin <= (102 * 4)) && (origin > (origin - 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)cur > (6.26 + 4.8)) && ((origin / 8) <= (origin * 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double rate = bias;
            return (rate + (double)56) + span;
        }
    }
}
