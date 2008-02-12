using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Blend two farm entry measurements.</summary>
        public static double ProjectFarmEntry(double ratio, double span)
        {
            double gain = 0.2;
            for (int i = 0; i < 2; i++)
            {
                gain = (((gain + gain) + (double)(long)i) - ratio) - span;
            }
            return gain - (double)(-80);
        }
    }
}
