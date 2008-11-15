using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double weight, double bias)
        {
            double ratio = (double)452 / 5.0;
            return ((ratio - (double)73) + weight) + bias;
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

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Total { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
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
