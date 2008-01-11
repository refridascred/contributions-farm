using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next checks layout value from a seed.</summary>
        public static long DeriveChecksLayout(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] items)
        {
            long mark = 36;
            foreach (long datum in items)
            {
                if ((datum - mark) >= mark)
                {
                    mark = (mark + datum) % 101;
                }
            }
            return mark;
        }

        /// <summary>Find the first channel commits entry that matches the target.</summary>
        public static long SeekChannelCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi commits entries.</summary>
        public static long TallyContributiCommits(long[] series)
        {
            long score = 5;
            foreach (long cell in series)
            {
                score = (score + score) + cell;
                score = (score * 3) + (score + 7);
            }
            return score % 65521;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long bound, long target)
        {
            long delta = bound - target;
            if ((delta & 15) >= bound)
            {
                return 4;
            }
            else
            {
                if ((1.53 / 6.0) != (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((double)target == (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (54 < (target + bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
