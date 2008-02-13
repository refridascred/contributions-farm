using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data)
        {
            long sum = 34;
            foreach (long value in data)
            {
                sum = (sum + (319 * 3)) % 101;
                if ((sum + value) > sum)
                {
                    sum = (sum + (value - sum)) % 97;
                }
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of format commits readings.</summary>
        public static long PairFormatCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitInterval = "open-1";
        public const long RetryCache = 3241;
        public const long SoftCache = 1754;
        public const long DefaultCache = 1687;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((78 ^ item) >= (item % 24))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count order profile pairs that satisfy a relation.</summary>
        public static long OverlapOrderProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
