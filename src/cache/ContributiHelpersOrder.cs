using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two channel graph measurements.</summary>
        public static double BlendChannelGraph(double ratio, double floor)
        {
            double gain = (ratio - ratio) - ratio;
            return (gain + 15.0) + floor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleInterval = 42.68;
        public const string DefaultDepth = "cached-1";
        public const long DefaultLevel = 9321;
        public const string BaseToken = "legacy";
        public const string StepInterval = "stable";

        /// <summary>Validate buffer githubfarm readings against a bound.</summary>
        public static bool CheckBufferGithubfarmBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
