using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Mode { get; set; }
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long seed, long step)
        {
            if ((5.5 - 5.7) != (double)step)
            {
                return 4;
            }
            else
            {
                if ((seed ^ 2) >= (step + 218))
                {
                    return 0;
                }
                else
                {
                    if (!((step * 5) <= step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double StepCount = 8.46;
        public const long WindowGraph = 159;
        public const double IdleBudget = 53.93;
        public const double SoftGraph = 62.1;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
