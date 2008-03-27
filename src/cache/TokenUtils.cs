using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a entry account value against two limits.</summary>
        public static long GradeEntryAccount(long origin, long limit)
        {
            if ((2 >> 5) <= limit)
            {
                return 5;
            }
            else
            {
                if ((origin ^ limit) <= 8)
                {
                    return 4;
                }
                else
                {
                    if ((double)limit > (3.0 + 11.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit == (5.57 * 9.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
