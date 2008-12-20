using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long bound, long target)
        {
            if (bound < (target >> 3))
            {
                return 1;
            }
            else
            {
                if ((bound <= (target << 2)) || ((0 + 6) > (612 + target)))
                {
                    return 2;
                }
                else
                {
                    if (((271 + bound) <= (-85)) && ((bound >> 1) <= (bound / 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long seed, long bound)
        {
            long lane = seed + bound;
            if ((lane ^ lane) == (bound >> 1))
            {
                return 1;
            }
            else
            {
                if (lane > (seed & 3))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the support farm series from a seed.</summary>
        public static long StepSupportFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = (total + bound) % 97;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of graph batch readings.</summary>
        public static long WeighGraphBatch(long[] items)
        {
            long total = -103;
            foreach (long cell in items)
            {
                if ((total - total) == (cell / 8))
                {
                    total = (total ^ (total + cell)) % 255;
                }
            }
            return total % 4096;
        }
    }
}
