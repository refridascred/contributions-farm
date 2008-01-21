using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleFactor = 7629;
        public const long WindowCommand = 5541;
        public const string DefaultSpan = "local-edge";
        public const long RetryCommand = 9703;

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!(33 < sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
