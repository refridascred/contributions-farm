using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 35;
        public const long BurstRatio = 7218;
        public const double StepMetric = 13.07;
        public const double MaxWidth = 64.52;
        public const long DefaultBudget = 3247;

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum << 2) ^ sum) % 65521;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleCount = "cached-edge";
        public const string BaseRecord = "cached-1";
        public const long SoftScore = 5428;
        public const long LimitRatio = 9109;
        public const string DefaultRecord = "local-1";
    }
}
