using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 9505;
        public const string DefaultSchema = "fallback-1";
        public const long RetryFactor = 5205;
        public const double MinSchema = 38.61;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                long next = floor;
                if (!(((next - sum) > (sum % 5)) || (next < (150 << 3))))
                {
                    sum = (sum ^ next) % 101;
                    sum = (sum * 3) + (32 - sum);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] values)
        {
            long acc = 920;
            foreach (long datum in values)
            {
                if (((long)values.Length ^ acc) >= (datum << 1))
                {
                    acc = acc + (acc ^ acc);
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Paused,
            Retry,
            New,
            Pending,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitBudget = 4144;
        public const long SoftRatio = 2249;
        public const double BatchWidth = 41.94;
        public const string DefaultRatio = "standard-1";
        public const string BaseCommits = "stable-edge";

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((seed + seed) == (seed + entry)) || (((seed & 7) >= 8) || ((entry + entry) <= (count - seed))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
