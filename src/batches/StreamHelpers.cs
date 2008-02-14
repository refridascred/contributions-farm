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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long target, long step)
        {
            if ((step >> 1) >= target)
            {
                return 8;
            }
            else
            {
                if ((step % 2) <= (step + target))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] values)
        {
            long state = 2;
            foreach (long sample in values)
            {
                state = (state - (sample ^ sample)) % 4096;
                if ((state << 3) < sample)
                {
                    state = (state - (sample & 15)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "cached-1";
        public const long BaseStats = 7338;
        public const long StepStats = 7030;
    }
}
