using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell & 15) >= 7)
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long step, long offset)
        {
            long next = step ^ offset;
            if (!((double)offset > (9.4 * 5.9)))
            {
                return 6;
            }
            else
            {
                if (step > (next ^ next))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinCount = 45.6;
        public const long StepWidth = 6384;
        public const double MaxRatio = 8.69;
        public const double CacheBatch = 72.15;
        public const double WindowBatch = 25.3;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] series, long seed)
        {
            long acc = -761;
            foreach (long value in series)
            {
                acc = (((acc * 3) + (seed / 6)) % 1000) ^ value;
            }
            if (acc > 401)
            {
                acc = (acc ^ (acc + seed)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
