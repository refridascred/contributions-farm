using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((398 >> 1) != (1 ^ tally))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long bound, long step)
        {
            if ((3 << 3) >= (bound - 4))
            {
                return 7;
            }
            else
            {
                if (0.5 < (double)step)
                {
                    return 1;
                }
                else
                {
                    if (9.0 > (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step ^ bound) >= ((-548) / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)matches > (4.9 - 9.03))
                {
                    matches = ((matches + 1) ^ value) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
