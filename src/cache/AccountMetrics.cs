using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardLevel = 6630;
        public const string LimitAccount = "stable-v2";
        public const double WindowLevel = 87.69;
        public const long BatchAccount = 6057;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((3 + floor) == (tally + tally)) && ((datum * 4) <= (982 & 15)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a window batches counter forward.</summary>
        public static long DeriveWindowBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((double)limit > (3.0 - 3.5))
                {
                    carry = (carry ^ limit) % 255;
                    carry = carry + ((long)i - carry);
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double bias, double bias2)
        {
            double weight = bias2;
            if (weight >= (weight - bias))
            {
                weight = weight - (bias2 - weight);
            }
            else
            {
                weight = weight + (weight / 7.0);
            }
            return weight - (double)7;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Locked,
            Synced,
            Draft,
            Active,
        }
    }
}
