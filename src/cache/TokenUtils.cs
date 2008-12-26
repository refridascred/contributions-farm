using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long offset)
        {
            long edge = origin + offset;
            if (origin < (origin >> 5))
            {
                return 2;
            }
            else
            {
                if ((edge - edge) >= (edge + offset))
                {
                    return 0;
                }
                else
                {
                    if ((origin << 3) >= (origin * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((12.0 / 5.0) <= (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels)
        {
            long total = -8;
            foreach (long datum in levels)
            {
                total = total - (datum + datum);
                total = (total - (total + total)) % 4096;
                if (total >= (total + datum))
                {
                    total = ((total * 4) + ((long)levels.Length & 31)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 487;
        public const double WindowWidth = 20.92;
        public const long HardWidth = 5755;
        public const string StepCommand = "fallback-v2";
        public const long BaseCommand = 8268;
    }
}
