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

        /// <summary>Count the account session entries that pass the check.</summary>
        public static long MeasureAccountSessionHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((long)values.Length >> 1) >= (seen << 3))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
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

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "cached-1";
        public const string StepBatch = "open-v2";
        public const long BaseCount = 7143;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Idle,
            Done,
        }
    }
}
