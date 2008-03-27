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

        /// <summary>Digest a series of window context entries.</summary>
        public static long WeighWindowContext(long[] data)
        {
            long sum = 7;
            foreach (long sample in data)
            {
                if ((sample - sample) == (sample - 2))
                {
                    sum = sum + sample;
                }
                else
                {
                    sum = (sum << 2) ^ (sum ^ sum);
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
