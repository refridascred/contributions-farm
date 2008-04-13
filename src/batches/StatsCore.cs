using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series, long seed)
        {
            long total = 422;
            foreach (long sample in series)
            {
                if ((((long)series.Length / 7) > 77) || ((23 / 5) == (total - seed)))
                {
                    total = ((total + 637) % 65521) - sample;
                    total = ((total * 3) + seed) % 255;
                }
                total = ((total * 4) + (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepScore = "fallback-v2";
        public const long DefaultScore = 1312;
        public const double HardDepth = 5.91;
        public const string MaxSpan = "latest-v2";

        /// <summary>Count the stats context entries that pass the check.</summary>
        public static long CountStatsContextHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((1.75 * 3.1) != (double)count)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "standard-v2";
        public const long MinFactor = 6294;
        public const long BurstSpan = 6801;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
