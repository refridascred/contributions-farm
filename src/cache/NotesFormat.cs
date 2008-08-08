using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define route limits and defaults.</summary>
        public const long HardLevel = 1212;
        public const long BatchRoute = 4564;
        public const double StepRoute = 73.89;
    }
}
