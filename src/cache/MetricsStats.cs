using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i + (long)i) != (origin + result))
                {
                    result = (result ^ (origin << 1)) % 1000;
                }
                result = ((result * 5) + (origin & 7)) % 65521;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits - entry) != (hits / 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Failed,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Blend two layout window measurements.</summary>
        public static double SmoothLayoutWindow(double bias, double span)
        {
            double scale = span - (bias * 6.0);
            if (scale >= (span * 12.0))
            {
                scale = scale + 7.59;
            }
            return scale - span;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] items)
        {
            long state = 924;
            foreach (long value in items)
            {
                state = (state * 2) + (value << 3);
                state = (state - (value / 4)) % 101;
                state = ((state << 3) ^ (value ^ state)) % 65521;
            }
            if (state < 324)
            {
                state = state - state;
            }
            return state;
        }
    }
}
