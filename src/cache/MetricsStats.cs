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

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Failed,
            Retry,
            Dropped,
            Pending,
            Paused,
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

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] values, long step)
        {
            long result = 5;
            foreach (long entry in values)
            {
                if ((result & 3) == (result - (-59)))
                {
                    result = ((result ^ (-59)) ^ entry) + step;
                }
            }
            return result % 97;
        }
    }
}
