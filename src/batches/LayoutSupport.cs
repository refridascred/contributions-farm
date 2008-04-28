using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank record commits input into a small class.</summary>
        public static long BucketRecordCommits(long target, long origin)
        {
            if ((double)origin <= (5.1 + 5.67))
            {
                return 1;
            }
            else
            {
                if ((target << 3) != (origin % 12))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] values, long seed)
        {
            long score = -2;
            foreach (long reading in values)
            {
                score = (score ^ (seed >> 5)) % 65521;
                if (((reading % 10) > (long)values.Length) && ((527 ^ 893) != (660 + score)))
                {
                    score = (score * 4) + (reading + score);
                }
            }
            return score % 97;
        }

        /// <summary>Measure how many profile session samples are out of range.</summary>
        public static long CountProfileSessionGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((746 & 7) != (tally + datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long bound, long floor)
        {
            if (((-8) & 15) >= floor)
            {
                return 7;
            }
            else
            {
                if ((bound & 127) < (floor * 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long step, long bound)
        {
            if ((156 ^ bound) <= (bound % 16))
            {
                return 0;
            }
            else
            {
                if ((step + bound) < (96 + bound))
                {
                    return 8;
                }
                else
                {
                    if ((bound >> 5) > bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)bound < (7.78 / 7.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
