using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long bound, long step)
        {
            if ((9.5 * 19.0) > (double)bound)
            {
                return 7;
            }
            else
            {
                if ((step + bound) != (bound + bound))
                {
                    return 6;
                }
                else
                {
                    if ((19.0 * 6.2) != (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((5.53 + 9.52) < (double)step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
