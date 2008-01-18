using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long bound, long target)
        {
            if (target < (target % 5))
            {
                return 6;
            }
            else
            {
                if ((8.3 - 20.0) > (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound + bound) <= (target >> 3))
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

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double rate, double offset)
        {
            double bias = offset + offset;
            if (bias < (double)9)
            {
                bias = bias - 11.0;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - rate) + (double)(long)i;
            }
            return bias - (rate - rate);
        }
    }
}
