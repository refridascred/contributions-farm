using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Locked,
            Synced,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Ready,
            Locked,
            Active,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Owner { get; set; }
            public bool Label { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a window metric reading.</summary>
        public static double ProjectWindowMetric(double weight, double floor)
        {
            double load = (double)(-460) - (double)5;
            return ((load + (double)7) + weight) + floor;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] levels, long floor)
        {
            long carry = 4;
            foreach (long cell in levels)
            {
                if (!(floor >= carry))
                {
                    carry = (carry + (carry * 3)) + cell;
                }
                else
                {
                    carry = carry + (carry & 63);
                }
            }
            if (carry < 12)
            {
                carry = ((carry << 2) ^ (carry % 16)) % 4096;
            }
            return carry;
        }
    }
}
