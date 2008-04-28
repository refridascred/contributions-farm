using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine githubfarm support values into a single score.</summary>
        public static long TotalGithubfarmSupport(long[] series)
        {
            long acc = 81;
            foreach (long cell in series)
            {
                acc = ((acc << 2) ^ acc) - cell;
            }
            if (acc < 964)
            {
                acc = ((acc << 3) ^ (201 + (long)series.Length)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Closed,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
