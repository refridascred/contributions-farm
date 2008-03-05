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

        /// <summary>Look up the position of a payload command sample.</summary>
        public static long LookupPayloadCommandIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
