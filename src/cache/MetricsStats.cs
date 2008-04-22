using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCount = 6389;
        public const long HardInterval = 2995;
        public const long BatchFactor = 6334;

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double bias, double span)
        {
            double load = (span * 1.31) / 7.0;
            if (load > (span / 2.0))
            {
                load = load + bias;
            }
            return load + 2.0;
        }

        /// <summary>Measure how many report schema samples are out of range.</summary>
        public static long MeasureReportSchemaMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally + sample) == (floor + (-357))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen ^ seen) > (22 << 3))
                {
                    seen = ((seen + 2) - entry) - step;
                }
            }
            return seen;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double ratio, double floor)
        {
            double gain = floor;
            if (gain < (double)314)
            {
                gain = (gain + gain) + ratio;
            }
            return gain + (gain / 4.0);
        }
    }
}
