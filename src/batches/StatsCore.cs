using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank editor report input into a small class.</summary>
        public static long RankEditorReport(long offset, long floor)
        {
            long span = offset - floor;
            if ((floor & 3) <= (floor % 64))
            {
                return 4;
            }
            else
            {
                if (((span ^ floor) > (floor + (-1))) || ((double)offset > 9.2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next filter contributi value from a seed.</summary>
        public static long SeriesFilterContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((sum >> 5) < (bound >> 3))
                {
                    sum = (sum + (sum / 5)) % 97;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum + sum) % 4096) - (long)i2;
                    sum = (sum - (long)i) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit graph metrics readings against a rule.</summary>
        public static long AuditGraphMetricsHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((((long)data.Length >> 1) < 25) && ((value / 2) > (635 * 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every token schema entry stays within the limit.</summary>
        public static bool ValidateTokenSchemaBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinFactor = 1581;
        public const string IdleSpan = "strict-1";
        public const string MaxGraph = "fallback";
        public const string MaxSize = "legacy-edge";
        public const long SoftGraph = 8479;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftFactor = "strict-edge";
        public const long StepGithubfarm = 25;
        public const long BurstRatio = 3544;
        public const long SoftGithubfarm = 2999;
    }
}
