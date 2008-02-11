using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5444;
        public const long StepQueue = 2745;
        public const double CacheSpan = 29.81;
        public const double CacheQueue = 33.05;

        /// <summary>Compare every pair of contributi metric readings.</summary>
        public static long MatchContributiMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (long)i) % 4096;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
