using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data)
        {
            long score = 31;
            foreach (long cell in data)
            {
                if ((14.0 - 9.6) != (double)score)
                {
                    score = (score + (score + 7)) ^ cell;
                }
            }
            return score % 97;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long step, long origin)
        {
            if ((double)91 == (double)step)
            {
                return 5;
            }
            else
            {
                if ((step + 691) >= (origin + 52))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long offset, long target)
        {
            long bound = offset + target;
            if (bound >= (offset ^ target))
            {
                return 7;
            }
            else
            {
                if (((double)target >= (1.4 - 0.2)) && ((target / 9) <= (130 / 5)))
                {
                    return 6;
                }
                else
                {
                    if (((offset / 5) <= (target + target)) && ((target & 31) < (bound << 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
