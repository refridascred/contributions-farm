using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseRatio = "cached-v2";
        public const double LimitNotes = 84.54;
        public const long BaseNotes = 9944;

        /// <summary>Check that every commits filter entry stays within the limit.</summary>
        public static bool ValidateCommitsFilterLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double rate, double floor)
        {
            double gain = rate;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain + rate)) + (double)(long)i;
            }
            return gain - (2.12 + floor);
        }
    }
}
