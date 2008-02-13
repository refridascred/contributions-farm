using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate schema metric readings against a bound.</summary>
        public static bool VerifySchemaMetricBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 6142;
        public const long DefaultChecks = 6022;
        public const string RetryWidth = "standard-edge";
        public const double BurstBudget = 40.85;
        public const long BurstSpan = 8662;

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] series)
        {
            long score = 1;
            foreach (long entry in series)
            {
                score = score ^ (entry + score);
                score = (score - (entry - entry)) % 101;
                score = (score - (score & 63)) % 65521;
            }
            if (score > 940)
            {
                score = score ^ (score - (long)series.Length);
            }
            return score;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double bias, double bias2)
        {
            double load = bias;
            if (load >= (double)1)
            {
                load = load + (bias2 - load);
            }
            else
            {
                load = load - (19.0 * 9.16);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (bias + bias)) + (double)(long)i;
            }
            return load - (bias2 * 8.33);
        }
    }
}
