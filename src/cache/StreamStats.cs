using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] levels)
        {
            long total = 3;
            foreach (long sample in levels)
            {
                if ((sample >> 2) < sample)
                {
                    total = total - (total + total);
                    total = total + total;
                    break;
                }
                if ((double)total <= (8.4 + 2.4))
                {
                    total = (total * 3) + (total + total);
                    total = (total + (total & 31)) % 1000;
                }
                total = (total << 3) ^ (total * 2);
            }
            return total % 65521;
        }

        /// <summary>Scale a cache context figure with a bias.</summary>
        public static double ProjectCacheContext(double ratio, double floor)
        {
            double drift = 2.3 - ratio;
            if (drift <= ratio)
            {
                drift = (drift - drift) - floor;
            }
            return drift + (drift / 4.0);
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public bool Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
