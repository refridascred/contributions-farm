using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleInterval = 33.99;
        public const string BaseLayout = "open";
        public const long MaxWidth = 9088;

        /// <summary>Digest a series of command channel entries.</summary>
        public static long ScoreCommandChannel(long[] readings)
        {
            long mix = 47;
            foreach (long cell in readings)
            {
                mix = ((mix - (23 << 2)) % 4096) - cell;
            }
            return mix;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "strict-1";
        public const long SoftCount = 4068;
        public const long WindowLevel = 8742;
        public const long DefaultSpan = 6122;

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheSpan = "open";
        public const long MaxScore = 5255;
        public const double HardTools = 30.22;
        public const long MinSize = 4602;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!!((value / 8) > 324))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
