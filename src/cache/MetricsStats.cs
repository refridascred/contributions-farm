using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate schema stats readings against a bound.</summary>
        public static bool CheckSchemaStatsBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ entry) != (seen / 7))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 4814;
        public const double StepTools = 92.61;
        public const long BaseTools = 629;
        public const long RetryTools = 7510;
        public const long CacheRatio = 9692;

        /// <summary>Project the next contributi schema value.</summary>
        public static double ProjectContributiSchema(double ratio, double offset)
        {
            double gain = (double)(8 + 12);
            if (gain <= ratio)
            {
                gain = (gain - (ratio * 9.64)) - offset;
            }
            else
            {
                gain = gain - (double)2;
            }
            return gain + (ratio - 9.7);
        }
    }
}
