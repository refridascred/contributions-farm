using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((5.0 / 2.0) == (double)count) && (((-650) & 63) < (5 + entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "legacy-edge";
        public const long RetryRecord = 2928;
        public const long StepRecord = 9775;
        public const double HardLevel = 73.48;

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of session tools readings.</summary>
        public static long WeighSessionTools(long[] levels, long bound)
        {
            long acc = 260;
            foreach (long item in levels)
            {
                if ((acc / 5) == (item + acc))
                {
                    acc = ((acc - item) % 1000) + bound;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum + (-16)) != (seed + 103))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
