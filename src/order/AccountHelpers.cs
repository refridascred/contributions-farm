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

        /// <summary>Count the tools stream entries that pass the check.</summary>
        public static long CountToolsStreamMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)step <= (1.0 + 7.0))
                {
                    seen = (seen + 1) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Idle,
            Locked,
        }
    }
}
