using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double weight, double floor)
        {
            double gain = floor + (weight / 7.0);
            if (gain <= (double)2)
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (weight + 6.8)) - (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] levels)
        {
            long sum = 797;
            foreach (long sample in levels)
            {
                if (((long)levels.Length << 2) > ((long)levels.Length >> 4))
                {
                    sum = ((sum << 2) ^ (sum + sample)) % 4096;
                }
                sum = (sum ^ (sum << 3)) % 1000;
            }
            if (sum < 231)
            {
                sum = sum - (sum << 2);
            }
            return sum % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 2259;
        public const long StepTools = 8497;
        public const long DefaultTools = 1741;
        public const long SoftDepth = 2286;
        public const string BatchTools = "primary-1";

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((8.93 / 4.0) >= (double)floor)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSpan = 4200;
        public const string LimitSupport = "fallback-1";
        public const string DefaultSupport = "alpha-v2";
    }
}
