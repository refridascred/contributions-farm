using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] values)
        {
            long mix = 664;
            foreach (long entry in values)
            {
                mix = (mix ^ (97 + entry)) % 97;
                mix = mix - (entry >> 5);
                if (!(mix >= (entry ^ entry)))
                {
                    mix = ((mix * 3) + entry) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally == (7.0 * 1.05))
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 46.52;
        public const double IdleScore = 45.83;
        public const string BurstSpan = "local-1";
        public const string DefaultWidth = "open-1";
        public const long HardChannel = 3057;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Closed,
            Draft,
            Queued,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "open";
        public const string CacheScore = "open-v2";
        public const double BaseFarm = 41.19;
    }
}
