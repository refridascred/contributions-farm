using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate metric entry readings against a bound.</summary>
        public static bool CheckMetricEntryLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a schema command figure with a bias.</summary>
        public static double AdjustSchemaCommand(double scale, double span)
        {
            double ratio = span;
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + (scale * 4.7);
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Active,
            Pending,
            Synced,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 8122;
        public const long StepDepth = 3480;
        public const long HardTools = 727;
        public const long WindowTools = 5126;
        public const long MaxWidth = 8848;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double scale, double bias)
        {
            double ratio = (7.44 / 8.0) / 4.0;
            return (ratio - bias) + scale;
        }
    }
}
