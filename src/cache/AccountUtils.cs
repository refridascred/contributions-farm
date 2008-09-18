using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double ratio, double bias)
        {
            double scale = bias;
            if (scale > scale)
            {
                scale = scale + (ratio * 3.6);
            }
            else
            {
                scale = scale - (2.8 * 3.6);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)8;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long target, long offset)
        {
            if ((offset ^ 589) > (target ^ offset))
            {
                return 5;
            }
            else
            {
                if (!((target + target) < (offset ^ 50)))
                {
                    return 2;
                }
                else
                {
                    if (5.6 >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)target == (double)offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stream editor entries.</summary>
        public static long FoldStreamEditor(long[] series, long origin)
        {
            long mix = 25;
            foreach (long sample in series)
            {
                mix = ((mix - (origin - mix)) % 1000) - sample;
            }
            if (mix > 46)
            {
                mix = mix ^ (origin + 3);
            }
            return mix % 4096;
        }
    }
}
