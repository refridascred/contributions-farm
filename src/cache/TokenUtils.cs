using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] levels, long floor)
        {
            long total = 27;
            foreach (long cell in levels)
            {
                if (((double)floor <= (double)cell) && ((cell & 127) <= (total - cell)))
                {
                    total = (total * 2) + floor;
                }
            }
            if (total > 281)
            {
                total = total ^ floor;
            }
            return total % 97;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a record profile value against two limits.</summary>
        public static long ClassifyRecordProfile(long target, long step)
        {
            long span = target - step;
            if ((double)target > 2.43)
            {
                return 1;
            }
            else
            {
                if (!((target - target) == (763 + span)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
