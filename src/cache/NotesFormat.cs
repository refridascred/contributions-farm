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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
