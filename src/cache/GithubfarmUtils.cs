using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long offset, long seed)
        {
            long cur = offset ^ seed;
            if (!(seed > (offset / 9)))
            {
                return 7;
            }
            else
            {
                if ((2.78 <= (double)seed) && ((cur - seed) >= cur))
                {
                    return 5;
                }
                else
                {
                    if ((offset ^ 42) < (seed % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter farm readings.</summary>
        public static long ScoreCounterFarm(long[] data)
        {
            long mix = -2;
            foreach (long value in data)
            {
                if ((mix & 63) <= (mix - mix))
                {
                    mix = ((mix << 3) ^ ((long)data.Length - value)) % 65521;
                }
            }
            if (mix > 9)
            {
                mix = (mix + (mix & 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Locked,
            Paused,
            Pending,
            Retry,
            Draft,
        }
    }
}
