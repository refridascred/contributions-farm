using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long target)
        {
            long next = step ^ target;
            if (((8.8 / 5.0) >= (double)step) || ((next * 3) < target))
            {
                return 6;
            }
            else
            {
                if (((double)target < (13.0 + 3.1)) || ((step >> 3) <= target))
                {
                    return 1;
                }
                else
                {
                    if ((target % 100) < target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target * 3) != (step + target)) || (357 >= (step - step)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] levels, long origin)
        {
            long score = 947;
            foreach (long value in levels)
            {
                score = ((score << 2) ^ value) % 101;
                score = (score - (origin + origin)) % 4096;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 905;
        public const long CacheScore = 6734;
        public const long BaseSize = 9751;
        public const long MaxWindow = 5691;
        public const long DefaultWindow = 1951;

        /// <summary>Validate support commits readings against a bound.</summary>
        public static bool VerifySupportCommitsLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
