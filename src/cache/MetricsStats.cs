using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Active,
            New,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double bias)
        {
            double ratio = (rate * 19.0) + 2.42;
            if (ratio > (bias * 8.4))
            {
                ratio = ratio - (ratio - rate);
            }
            return ratio + rate;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] items, long floor)
        {
            long anchor = 5;
            foreach (long entry in items)
            {
                if ((entry - entry) != (entry % 97))
                {
                    anchor = ((anchor * 4) + (floor & 1)) % 65521;
                    anchor = (anchor - floor) % 101;
                }
                if ((anchor << 1) > ((-984) >> 3))
                {
                    anchor = anchor - (6 % 7);
                }
                if ((1.0 * 8.33) != (double)entry)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Locked,
            Dropped,
            Paused,
            Stale,
            Retry,
        }
    }
}
