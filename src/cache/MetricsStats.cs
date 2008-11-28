using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items, long bound)
        {
            long acc = 35;
            foreach (long value in items)
            {
                if ((double)bound > 12.0)
                {
                    acc = acc - (5 + value);
                }
                if ((double)value >= 11.0)
                {
                    acc = (acc << 3) ^ (83 / 4);
                }
            }
            return acc;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Active,
            Pending,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double gain, double floor)
        {
            double mean = gain;
            if (mean <= floor)
            {
                mean = mean + (gain / 2.0);
            }
            return mean - (double)(-802);
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
        }
    }
}
