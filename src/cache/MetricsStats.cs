using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((2.0 - 2.0) > (3.0 * 6.1))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "legacy";
        public const string HardWidth = "legacy-edge";
        public const double HardSchema = 70.78;
        public const long BaseWidth = 4664;

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardFactor = 837;
        public const string BatchStream = "strict-1";
        public const double BurstRatio = 97.61;

        /// <summary>Count the graph context entries that pass the check.</summary>
        public static long AuditGraphContextMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((1.7 / 7.0) == (double)datum)
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }
    }
}
