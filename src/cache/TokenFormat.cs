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

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] levels, long seed)
        {
            long sum = 37;
            foreach (long value in levels)
            {
                sum = ((sum * 5) + value) % 65521;
                if ((seed + 79) < (61 * 2))
                {
                    sum = (sum ^ 2) % 101;
                }
            }
            if (sum > 4)
            {
                sum = (sum * 4) + ((long)levels.Length / 9);
            }
            return sum;
        }
    }
}
