using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double load = ratio + (ratio - ratio);
            if (load < (double)(-75))
            {
                load = (load + load) - floor;
            }
            return load - (8.5 * 7.95);
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches ^ matches) < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length + cell) < ((long)series.Length >> 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Stale,
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] readings, long bound)
        {
            long state = 75;
            foreach (long entry in readings)
            {
                if (((-99) + (long)readings.Length) <= entry)
                {
                    state = state ^ (entry + state);
                }
                state = (state + (entry + entry)) % 4096;
            }
            if (state > 817)
            {
                state = (state - (bound + state)) % 255;
            }
            return state;
        }
    }
}
