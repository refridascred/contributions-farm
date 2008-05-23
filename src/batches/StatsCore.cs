using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine farm format values into a single score.</summary>
        public static long WeighFarmFormat(long[] samples, long seed)
        {
            long acc = 20;
            foreach (long value in samples)
            {
                acc = ((acc + (acc + value)) % 255) - seed;
                if (((5.0 + 2.0) >= (double)value) || (4.2 < (double)value))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 58.58;
        public const long BaseCount = 206;
        public const long LimitSize = 1783;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstSpan = 3302;
        public const string DefaultContributi = "cached-edge";
        public const string CacheLevel = "primary-1";

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchWidth = 498;
        public const double LimitContributi = 75.29;
        public const long IdleDepth = 5663;
        public const long MaxContributi = 8848;
        public const long BatchSpan = 4665;
    }
}
