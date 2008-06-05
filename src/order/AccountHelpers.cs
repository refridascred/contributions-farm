using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseLevel = 4.99;
        public const string SoftGraph = "fallback-edge";
        public const long HardSpan = 762;
        public const long IdleRatio = 8595;

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "staging-1";
        public const double StepBudget = 0.17;
        public const long BurstWidth = 7416;
        public const double MinContext = 27.62;

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + ((long)i * 3)) % 4096;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (sample <= (matches & 1))
                {
                    matches = (matches + 2) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item + item) < (item << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(((seen % 8) >= (seen + 17)) || ((2 - seen) <= (entry - seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
