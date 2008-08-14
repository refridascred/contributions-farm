using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count token already pairs that satisfy a relation.</summary>
        public static long OverlapTokenAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter report entries that pass the check.</summary>
        public static long AuditCounterReportGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)bound < (8.0 / 6.0)) || (((bound + count) == (bound & 63)) && ((double)entry == (0.62 * 8.8))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
