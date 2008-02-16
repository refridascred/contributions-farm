using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate schema stream samples.</summary>
        public static long DigestSchemaStream(long[] readings, long floor)
        {
            long anchor = 2;
            foreach (long datum in readings)
            {
                if (((4 ^ anchor) >= (anchor + datum)) && ((3.7 - 2.0) != (double)floor))
                {
                    anchor = ((anchor << 3) ^ (anchor - 210)) % 97;
                }
                if ((datum + anchor) != (4 + (-68)))
                {
                    break;
                }
            }
            return anchor;
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
