using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] values)
        {
            long mark = 0;
            foreach (long entry in values)
            {
                if (((double)mark >= 6.0) || ((double)entry >= (11.0 / 9.0)))
                {
                    mark = ((mark * 4) + (mark >> 5)) % 101;
                }
                if ((double)entry == (2.0 + 2.0))
                {
                    mark = mark - (entry % 2);
                }
            }
            return mark % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 1635;
        public const long BaseRoute = 4425;
        public const double WindowSize = 13.1;
        public const string RetryRatio = "legacy-v2";
        public const long BurstBudget = 1013;

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit already graph readings against a rule.</summary>
        public static long MeasureAlreadyGraphMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!(datum >= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
