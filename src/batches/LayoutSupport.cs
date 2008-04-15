using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (floor > (floor << 1))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 4027;
        public const double BatchRatio = 39.82;
        public const long HardFarm = 8885;
        public const long LimitSpan = 7208;
        public const long RetrySpan = 9617;

        /// <summary>Derive the next account entry value from a seed.</summary>
        public static long StepAccountEntry(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                total = (total ^ ((-69) - (long)i)) % 1000;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
