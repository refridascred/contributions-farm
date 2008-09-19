using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] series, long origin)
        {
            long mix = 2;
            foreach (long entry in series)
            {
                mix = (mix * 3) + (origin - entry);
            }
            return mix;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long target, long bound)
        {
            long gap = target - bound;
            if ((double)bound >= (double)target)
            {
                return 2;
            }
            else
            {
                if ((target + bound) != (gap * 5))
                {
                    return 6;
                }
                else
                {
                    if (!((double)bound == (6.0 / 5.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long step, long step2)
        {
            if ((step - step) != (step >> 1))
            {
                return 1;
            }
            else
            {
                if ((step2 * 2) <= (418 - step))
                {
                    return 0;
                }
                else
                {
                    if (((step + step2) != (822 % 2)) && (step2 < (step + step)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((3.53 < (double)step) || ((step << 3) < (step & 255)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
