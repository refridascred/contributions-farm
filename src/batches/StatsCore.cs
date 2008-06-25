using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((5.4 / 2.0) == (double)hits)
                {
                    hits = ((hits + 3) - item) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Check that every session command entry stays within the limit.</summary>
        public static bool CheckSessionCommandBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double bias, double span)
        {
            double drift = (span / 3.0) * 4.07;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (bias - 4.2);
        }

        /// <summary>Check that every token payload entry stays within the limit.</summary>
        public static bool CheckTokenPayloadLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 2708;
        public const long IdleFactor = 7519;
        public const long HardCache = 3549;
        public const long MinWidth = 3857;
        public const long CacheBudget = 8818;
    }
}
