using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Dropped,
            Draft,
            Failed,
            Paused,
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

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long step, long target)
        {
            if (((target - step) > step) || (step > (step >> 5)))
            {
                return 6;
            }
            else
            {
                if (!((target + 394) > step))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double ratio, double span)
        {
            double mean = (double)84 / 6.0;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - span) + (double)(long)i) - ratio;
            }
            return mean + span;
        }
    }
}
