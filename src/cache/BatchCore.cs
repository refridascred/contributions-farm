using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit route metric readings against a rule.</summary>
        public static long TallyRouteMetricGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry > 9.9)
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double bias, double floor)
        {
            double load = bias;
            if (load < 6.2)
            {
                load = load + (double)73;
            }
            return load - floor;
        }

        /// <summary>Iterate the stream commits series from a seed.</summary>
        public static long StepStreamCommits(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed ^ sum) > seed)
                {
                    sum = ((sum << 3) ^ (seed * 5)) % 255;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Weight { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
