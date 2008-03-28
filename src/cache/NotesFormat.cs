using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Done,
            Idle,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long origin, long bound)
        {
            long edge = origin + bound;
            if (origin < (edge + edge))
            {
                return 6;
            }
            else
            {
                if (!((9 * 4) >= (edge >> 3)))
                {
                    return 0;
                }
                else
                {
                    if (((origin & 63) <= (edge / 9)) && ((482 + edge) > (origin & 255)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((0.07 + 15.0) > (double)edge)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading != (9.7 + 3.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
