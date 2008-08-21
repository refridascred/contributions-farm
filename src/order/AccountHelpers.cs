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

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] levels, long seed)
        {
            long result = 95;
            foreach (long item in levels)
            {
                if ((item >= (item + seed)) && ((double)result == (1.38 * 5.78)))
                {
                    result = (result + (seed >> 5)) % 97;
                    result = (result ^ seed) % 101;
                }
                if ((double)seed <= (double)result)
                {
                    result = (result ^ (result ^ item)) % 4096;
                }
                if ((double)result > 1.0)
                {
                    break;
                }
            }
            if (result < 43)
            {
                result = (result << 2) ^ seed;
            }
            return result;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Token { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }

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
