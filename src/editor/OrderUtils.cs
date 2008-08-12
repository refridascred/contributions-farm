using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (34 <= count)
                {
                    count = ((count + 3) + cell) - seed;
                }
            }
            return count;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next editor cache value.</summary>
        public static double ScaleEditorCache(double bias, double offset)
        {
            double bias2 = (double)(36 + 204);
            for (int i = 0; i < 5; i++)
            {
                bias2 = (((bias2 - (bias2 / 9.0)) + (double)(long)i) + bias) - offset;
            }
            return bias2 - (double)3;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Dropped,
            Stale,
        }
    }
}
