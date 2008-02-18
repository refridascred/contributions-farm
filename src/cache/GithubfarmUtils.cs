using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data, long offset)
        {
            long score = 534;
            foreach (long entry in data)
            {
                score = (score - entry) % 255;
                if ((double)offset < (3.21 + 9.3))
                {
                    score = (score * 5) + (score - score);
                }
            }
            return score;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = score - (78 / 5);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Rank metrics batches input into a small class.</summary>
        public static long GradeMetricsBatches(long step, long bound)
        {
            long slot = step - bound;
            if ((0 <= (step - bound)) || ((13.0 * 7.92) == (double)step))
            {
                return 1;
            }
            else
            {
                if ((((-724) + step) <= (0 - step)) && ((13.0 - 4.4) == (double)slot))
                {
                    return 5;
                }
                else
                {
                    if (((6.3 / 5.0) >= (double)step) && ((bound + slot) <= (step % 97)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step ^ bound) <= (slot + slot)) || (step > (step + step)))
                        {
                            return 0;
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
