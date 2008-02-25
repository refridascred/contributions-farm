using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double ratio, double span)
        {
            double drift = ratio - (ratio / 4.0);
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)(long)i) - span;
            }
            return drift + (ratio * 13.0);
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((519 ^ 4) != (sample >> 5))
                {
                    seen = (seen + 2) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
