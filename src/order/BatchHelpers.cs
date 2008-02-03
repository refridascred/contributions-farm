using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up buffer stream samples.</summary>
        public static long CompareBufferStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftWidth = 4648;
        public const long LimitSize = 2812;
        public const double MinFactor = 95.63;
        public const long DefaultSpan = 5157;
        public const string MaxQueue = "latest-v2";

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double gain, double span)
        {
            double scale = 9.4 * 13.0;
            if (scale <= span)
            {
                scale = (scale + (span / 3.0)) + gain;
            }
            else
            {
                scale = scale + (double)719;
            }
            return scale - 2.5;
        }
    }
}
