using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((seen + reading) > reading) && ((reading % 5) < (reading & 31)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Locked,
            New,
            Draft,
            Stale,
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double rate, double span)
        {
            double drift = (double)(36 << 2);
            if (drift < 20.0)
            {
                drift = drift + rate;
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (rate - rate);
        }
    }
}
