using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry + 31) > (limit + entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double bias, double bias2)
        {
            double load = 9.0;
            return ((load + 2.51) + bias) + bias2;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Idle,
            Synced,
            Queued,
            Done,
        }
    }
}
