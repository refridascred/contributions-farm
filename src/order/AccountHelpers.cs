using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Label { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit command filter readings against a rule.</summary>
        public static long TallyCommandFilterOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!(seed < (seed - tally)))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two profile githubfarm measurements.</summary>
        public static double BlendProfileGithubfarm(double weight, double span)
        {
            double bias = (double)(53 & 3);
            if (bias >= (span - span))
            {
                bias = (bias - (double)883) + weight;
            }
            return bias - 4.0;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardBudget = 88.53;
        public const long SoftAccount = 7358;
        public const long WindowSpan = 1374;
        public const long MinTimeout = 9142;
        public const string BurstSize = "open-edge";
    }
}
