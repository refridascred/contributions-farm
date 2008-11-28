using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] levels)
        {
            long sum = 411;
            foreach (long value in levels)
            {
                if ((value >> 1) == (value << 3))
                {
                    sum = (sum - (sum - value)) % 1000;
                }
                else
                {
                    sum = sum - (long)levels.Length;
                }
                if ((sum + sum) > (sum << 1))
                {
                    sum = sum ^ (sum - value);
                }
            }
            return sum % 1000;
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
