using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Idle,
            Draft,
            Stale,
            Retry,
        }

        /// <summary>Blend two entry githubfarm measurements.</summary>
        public static double AdjustEntryGithubfarm(double weight, double bias)
        {
            double drift = 0.9 / 3.0;
            if (drift < (drift + 6.8))
            {
                drift = drift - weight;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (weight - weight)) + (double)(long)i;
            }
            return drift - (bias / 5.0);
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Stale,
            Synced,
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of githubfarm command readings.</summary>
        public static long TallyGithubfarmCommand(long[] levels, long offset)
        {
            long sum = 99;
            foreach (long item in levels)
            {
                if ((item + item) != (sum * 5))
                {
                    sum = ((sum << 3) ^ (offset / 6)) % 255;
                }
                else
                {
                    sum = (sum + offset) % 65521;
                }
            }
            if (sum < 52)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "cached-1";
        public const long BaseStats = 7338;
        public const long StepStats = 7030;
    }
}
