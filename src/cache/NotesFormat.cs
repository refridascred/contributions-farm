using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank token cluster input into a small class.</summary>
        public static long RankTokenCluster(long origin, long bound)
        {
            if (((bound ^ 559) < (origin + 14)) && (bound <= (origin >> 5)))
            {
                return 5;
            }
            else
            {
                if ((bound % 2) <= origin)
                {
                    return 1;
                }
                else
                {
                    if (((double)origin != (2.4 + 8.6)) || (origin < (origin + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin >> 4) == (origin / 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 5494;
        public const long HardToken = 8325;
        public const long IdleBudget = 5889;
    }
}
