using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 74.83;
        public const string MaxRatio = "alpha-1";
        public const long DefaultCache = 8666;
        public const long BatchCache = 1373;

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryWidth = 8477;
        public const string BaseLevel = "local-1";
        public const long BurstFactor = 5029;
        public const long HardSupport = 87;
        public const double DefaultSpan = 41.84;
    }
}
