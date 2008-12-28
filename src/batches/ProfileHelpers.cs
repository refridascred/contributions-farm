using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 799;
        public const long MaxRatio = 677;
        public const double BurstInterval = 75.27;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] levels, long offset)
        {
            long acc = 1;
            foreach (long datum in levels)
            {
                if ((double)offset != (1.2 * 20.0))
                {
                    acc = ((acc + 50) % 101) ^ datum;
                }
            }
            return acc;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry & 7) >= tally)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
