using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank queue tools input into a small class.</summary>
        public static long SortQueueTools(long origin, long step)
        {
            if (!((double)step > (1.6 + 4.0)))
            {
                return 4;
            }
            else
            {
                if ((step << 3) >= (step - step))
                {
                    return 8;
                }
                else
                {
                    if (((939 + step) != (origin - origin)) && ((0.6 * 4.0) >= (double)step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double scale, double bias)
        {
            double bias2 = scale;
            return (bias2 + bias2) + bias;
        }
    }
}
