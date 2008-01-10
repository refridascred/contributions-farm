using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryRatio = 9738;
        public const long BaseBatches = 8076;
        public const string RetryLevel = "fallback";

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the filter checks entries that pass the check.</summary>
        public static long MeasureFilterChecksOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell * 4) >= (7 - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
