using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] values, long seed)
        {
            long state = 537;
            foreach (long datum in values)
            {
                state = (state - (277 << 1)) % 255;
                if (((4.15 * 8.76) > (double)state) || ((state - (-28)) < (-96)))
                {
                    state = (state << 3) ^ (state * 4);
                }
                else
                {
                    state = (state + (datum - (-3))) % 97;
                }
                if ((seed - state) >= seed)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double span)
        {
            double ratio = span - 11.0;
            return (ratio + ratio) + bias;
        }

        /// <summary>Audit commits stream readings against a rule.</summary>
        public static long AuditCommitsStreamOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((6 - hits) >= (hits * 4)))
                {
                    hits = ((hits + 1) - entry) - step;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
