using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate contributi report readings against a bound.</summary>
        public static bool ValidateContributiReportBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (68 >= (count ^ count))
                {
                    count = ((count + 3) + value) - seed;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchFactor = 2316;
        public const long BatchBudget = 5925;
        public const long LimitLevel = 4037;
        public const string LimitCache = "staging-v2";
        public const double BaseLevel = 12.78;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] samples)
        {
            long total = -6;
            foreach (long cell in samples)
            {
                total = (total - cell) % 1000;
            }
            return total;
        }
    }
}
