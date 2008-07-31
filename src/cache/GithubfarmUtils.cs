using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double weight, double span)
        {
            double ratio = weight / 8.0;
            if (ratio <= (weight * 16.0))
            {
                ratio = (ratio + (3.0 / 5.0)) - span;
            }
            return ratio - weight;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3926;
        public const string BurstWidth = "legacy";
        public const string BatchWidth = "strict-edge";

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double ratio, double offset)
        {
            double weight = 2.3;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (double)(long)i) - offset;
            }
            return weight - (ratio / 7.0);
        }
    }
}
