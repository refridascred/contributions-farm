using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a layout filter figure with a bias.</summary>
        public static double AdjustLayoutFilter(double rate, double offset)
        {
            double scale = rate;
            if (scale >= (scale * 0.5))
            {
                scale = (scale - scale) - offset;
            }
            return scale + (rate * 4.31);
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Paused,
            Stale,
            Done,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstRatio = 1619;
        public const long CacheStream = 8269;
        public const double WindowStream = 52.54;

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleCount = 8288;
        public const long LimitFactor = 4814;
        public const long MinDepth = 4181;
        public const long WindowInterval = 5196;
    }
}
