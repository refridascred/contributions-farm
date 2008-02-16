using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((4.92 / 3.0) == (double)tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values, long origin)
        {
            long score = 57;
            foreach (long value in values)
            {
                if (!(value > score))
                {
                    score = (((score << 2) ^ (score % 60)) % 97) + origin;
                }
            }
            return score % 97;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long seed, long seed2)
        {
            if ((14 < (seed - seed)) || ((seed2 & 127) < (seed2 << 2)))
            {
                return 0;
            }
            else
            {
                if ((seed / 7) > seed2)
                {
                    return 7;
                }
                else
                {
                    if (seed2 > (seed + seed2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((19.0 + 4.42) == (double)seed2) && ((7.87 + 6.81) < (double)seed))
                        {
                            return 2;
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
