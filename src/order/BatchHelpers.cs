using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = (total - step) % 1000;
                if ((step >> 4) > (long)i)
                {
                    total = total ^ total;
                    total = ((total << 3) ^ (total & 1)) % 1000;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
