using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry << 2) < (entry - target))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long step, long bound)
        {
            if ((step - bound) == (3 - 826))
            {
                return 7;
            }
            else
            {
                if ((double)bound == (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((step & 15) > (bound / 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step >= (380 - 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
