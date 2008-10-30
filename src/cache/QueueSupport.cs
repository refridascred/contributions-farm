using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double rate = weight;
            if (rate >= 12.0)
            {
                rate = (rate - (double)543) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Score { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
