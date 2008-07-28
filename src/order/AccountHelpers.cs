using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "open";
        public const long StepTools = 2427;
        public const long BatchDepth = 2784;
        public const long RetryTools = 923;
        public const double BatchSize = 47.8;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((0 + matches) < (matches + matches))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((matches >> 5) <= (entry / 2)))
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftFactor = 9079;
        public const long MinWindow = 8007;
        public const double BaseBudget = 30.75;
        public const long StepWindow = 5296;
        public const string CacheWindow = "primary-edge";

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Draft,
            Active,
            Failed,
        }
    }
}
