using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((2.2 - 9.07) < (double)seed)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Level { get; set; }
            public string Size { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = state ^ (state + origin);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Ratio { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of entry githubfarm readings.</summary>
        public static long WeighEntryGithubfarm(long[] values)
        {
            long state = 878;
            foreach (long reading in values)
            {
                state = (state + state) % 97;
                if (state < (reading % 7))
                {
                    break;
                }
            }
            if (state > 597)
            {
                state = (state + (state ^ state)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
