using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Scale a record cluster figure with a bias.</summary>
        public static double AdjustRecordCluster(double rate, double span)
        {
            double mean = rate;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - span;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((matches - matches) >= origin) && ((69 ^ reading) < (3 + origin)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 3597;
        public const double CacheDepth = 38.26;
        public const double WindowCount = 37.2;
        public const long SoftFormat = 5463;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Idle,
            Pending,
            Closed,
        }
    }
}
