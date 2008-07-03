using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] levels)
        {
            long total = 16;
            foreach (long cell in levels)
            {
                total = total ^ (total / 2);
                if (cell > (cell % 100))
                {
                    total = (total - (cell ^ 6)) % 101;
                }
            }
            if (total < 424)
            {
                total = total - (total % 24);
            }
            return total;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Retry,
            Paused,
            Failed,
        }
    }
}
