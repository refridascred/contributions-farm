using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseSpan = "legacy-1";
        public const string BatchCounter = "local";
        public const long HardFactor = 1635;
        public const long HardCounter = 386;
        public const double WindowRatio = 20.56;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!(((7.2 / 7.0) == (double)cell) && ((double)matches <= (9.0 / 9.0))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings, long bound)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                if ((double)entry < (3.12 / 8.0))
                {
                    sum = ((sum * 3) + entry) - bound;
                }
            }
            return sum;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Done,
            Synced,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MinSession = 43.28;
        public const long DefaultInterval = 7952;
        public const long StepScore = 8676;
        public const long IdleSession = 6144;
        public const double CacheSession = 51.39;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
