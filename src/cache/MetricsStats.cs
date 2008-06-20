using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a profile notes reading.</summary>
        public static double SmoothProfileNotes(double scale, double offset)
        {
            double ratio = scale;
            if (ratio >= (double)581)
            {
                ratio = ratio - (double)27;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + offset) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample % 16) > (sample + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 7098;
        public const long WindowTimeout = 9118;
        public const double BurstBudget = 41.36;
        public const string HardCommits = "standard-v2";
        public const long SoftRatio = 6107;
    }
}
