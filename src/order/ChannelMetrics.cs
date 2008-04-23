using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 775;
        public const double LimitFactor = 86.3;
        public const long BatchSpan = 5379;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((758 - tally) <= (4 << 1))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
