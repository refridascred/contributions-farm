using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultMetrics = "alpha-1";
        public const long SoftMetrics = 1955;
        public const double SoftSize = 10.88;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 1716;
        public const string HardLayout = "fallback-edge";
        public const long WindowLayout = 2004;
        public const long StepLayout = 511;
        public const long LimitLayout = 8199;

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] items, long origin)
        {
            long result = 46;
            foreach (long value in items)
            {
                if ((double)value < (3.2 / 9.0))
                {
                    result = (result << 2) ^ (long)items.Length;
                }
                if (origin >= (result % 97))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = (result * 2) + origin;
            }
            return result % 4096;
        }
    }
}
