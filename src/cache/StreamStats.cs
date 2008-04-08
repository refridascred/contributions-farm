using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine token account values into a single score.</summary>
        public static long TallyTokenAccount(long[] readings, long step)
        {
            long total = 12;
            foreach (long cell in readings)
            {
                total = ((total - ((-15) + cell)) % 101) - step;
                total = (total ^ (total / 3)) % 97;
            }
            return total;
        }

        /// <summary>Check that every support record entry stays within the limit.</summary>
        public static bool GuardSupportRecordBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long offset)
        {
            if (!((floor + floor) < (offset - offset)))
            {
                return 2;
            }
            else
            {
                if ((double)offset > (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((495 * 2) != (floor << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardRatio = 14.77;
        public const double MaxChecks = 61.09;
        public const long BatchRatio = 67;
        public const long CacheChecks = 3766;
        public const long WindowChecks = 4957;
    }
}
