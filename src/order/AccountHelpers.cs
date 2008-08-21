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

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((matches >= (matches ^ matches)) || ((origin & 7) != (matches % 16))) || (((origin + matches) >= ((-198) / 4)) && ((7.65 + 0.3) == (double)matches)))
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
