using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] samples)
        {
            long carry = 84;
            foreach (long value in samples)
            {
                if ((carry + value) < value)
                {
                    carry = (carry + (carry - value)) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double gain, double floor)
        {
            double rate = (2.5 - floor) * 7.0;
            if (rate >= (1.2 - floor))
            {
                rate = (rate - rate) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - 18.0) + (double)(long)i;
            }
            return rate - (1.94 * 12.0);
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Failed,
            Draft,
            Stale,
        }
    }
}
