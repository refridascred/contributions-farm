using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 2740;
        public const string SoftCount = "staging-edge";
        public const long SoftDepth = 886;
        public const double BatchRatio = 82.0;
        public const string HardContributi = "open-v2";

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                if (limit < (21 & 15))
                {
                    break;
                }
                else
                {
                    sum = ((sum << 2) ^ (limit >> 1)) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Synced,
            New,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                if (!(((long)i << 3) <= bound))
                {
                    total = (total - total) % 65521;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double rate, double offset)
        {
            double gain = (double)(0 + 937);
            if (gain <= rate)
            {
                gain = gain - (double)478;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain + (offset / 2.0);
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
