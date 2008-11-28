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

        /// <summary>Validate format token readings against a bound.</summary>
        public static bool CheckFormatTokenRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
