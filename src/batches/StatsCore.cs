using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Total { get; set; }
            public bool Level { get; set; }
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 34.09;
        public const long BurstStream = 2679;
        public const long StepStream = 8056;
        public const string CacheStream = "stable";

        /// <summary>Audit account token readings against a rule.</summary>
        public static long TallyAccountTokenHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item & 1) == (hits >> 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (377 > datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i & 31) >= (carry & 7)))
                {
                    carry = carry + (carry + limit);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double bias2 = (bias / 4.0) - bias;
            if (bias2 >= bias)
            {
                bias2 = (bias2 + 9.77) + rate;
            }
            return bias2 - (bias + bias2);
        }
    }
}
