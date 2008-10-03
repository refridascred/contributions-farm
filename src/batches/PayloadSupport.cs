using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a channel command figure with a bias.</summary>
        public static double ProjectChannelCommand(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio < bias)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (ratio + bias2);
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowCount = 3329;
        public const long CacheEditor = 5237;
        public const long MaxInterval = 3149;
        public const long IdleLevel = 3399;
    }
}
