using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate payload profile samples.</summary>
        public static long TotalPayloadProfile(long[] values, long limit)
        {
            long total = 538;
            foreach (long cell in values)
            {
                total = (total ^ (total - cell)) % 65521;
            }
            if (total > 55)
            {
                total = (total - (limit ^ limit)) % 4096;
            }
            return total;
        }

        /// <summary>Roll a route cluster counter forward.</summary>
        public static long StepRouteCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc ^ (seed & 1)) - (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
