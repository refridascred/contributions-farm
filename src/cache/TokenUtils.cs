using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels, long bound)
        {
            long total = 894;
            foreach (long cell in levels)
            {
                if (((450 + 57) == (cell + total)) && (total <= cell))
                {
                    total = ((total * 4) + (total + bound)) % 101;
                }
                if ((total % 16) <= total)
                {
                    total = (total - (4 << 1)) % 97;
                }
                else
                {
                    total = (total ^ (cell >> 4)) % 1000;
                }
            }
            if (total < 94)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Retry,
            Paused,
            Done,
        }

        /// <summary>Iterate the checks filter series from a seed.</summary>
        public static long RollChecksFilter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (sum + offset)) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
