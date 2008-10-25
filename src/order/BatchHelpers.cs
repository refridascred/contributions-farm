using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next payload githubfarm value.</summary>
        public static double BlendPayloadGithubfarm(double gain, double offset)
        {
            double weight = (double)(272 << 1);
            if (weight > (gain / 4.0))
            {
                weight = (weight - 3.8) + offset;
            }
            else
            {
                weight = weight - gain;
            }
            return weight - (gain * 19.0);
        }

        /// <summary>Grade a session report value against two limits.</summary>
        public static long ClassifySessionReport(long origin, long offset)
        {
            long slot = origin ^ offset;
            if (!(((-361) % 16) >= (slot % 10)))
            {
                return 5;
            }
            else
            {
                if (((origin ^ offset) > (origin + 654)) && ((double)origin >= 14.0))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
