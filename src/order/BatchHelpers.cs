using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultScore = 7584;
        public const double StepWindow = 36.67;
        public const long DefaultWindow = 2558;
        public const string CacheWidth = "cached";

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
