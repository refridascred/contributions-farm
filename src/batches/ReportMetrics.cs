using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the cache command series from a seed.</summary>
        public static long DeriveCacheCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry << 2) ^ (origin + origin);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((13.0 - 0.4) != (double)seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleFactor = "strict-edge";
        public const long WindowBatch = 6481;
        public const double SoftScore = 0.67;
        public const long SoftSpan = 2079;
    }
}
