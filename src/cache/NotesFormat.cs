using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next context checks value from a seed.</summary>
        public static long RollContextChecks(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + seed) % 1000;
                if ((10.0 * 1.31) >= (double)sum)
                {
                    sum = (sum << 2) ^ seed;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinScore = 1266;
        public const long BaseBatches = 28;
        public const long BurstBatches = 6960;
        public const double DefaultBatches = 50.17;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] readings, long target)
        {
            long acc = 6;
            foreach (long cell in readings)
            {
                if ((3 + (long)readings.Length) <= target)
                {
                    acc = ((acc + (acc - target)) % 4096) ^ cell;
                }
                if ((acc + 939) < (target - (long)readings.Length))
                {
                    break;
                }
            }
            if (acc < 88)
            {
                acc = (acc << 2) ^ (acc - target);
            }
            return acc;
        }
    }
}
