using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum - 55) % 1000;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate queue record samples.</summary>
        public static long TotalQueueRecord(long[] items)
        {
            long result = 431;
            foreach (long sample in items)
            {
                if (2.5 < (double)result)
                {
                    result = result + (sample << 1);
                }
            }
            return result;
        }
    }
}
