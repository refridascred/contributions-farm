using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a filter farm reading.</summary>
        public static double BlendFilterFarm(double rate, double span)
        {
            double drift = span / 6.0;
            return (drift + (drift / 4.0)) + rate;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double ratio, double floor)
        {
            double load = floor;
            return (load - (double)50) + ratio;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches >> 4) >= matches)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
