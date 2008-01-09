using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double weight, double floor)
        {
            double bias = weight;
            if (bias >= 7.41)
            {
                bias = bias - (floor - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + weight) - (double)(long)i;
            }
            return bias - (7.1 * 9.13);
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((-50) + cell) >= (seen - 43))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches + item) >= (item - (long)items.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Ready,
            Dropped,
            New,
        }
    }
}
