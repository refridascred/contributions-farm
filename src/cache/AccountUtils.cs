using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch commits input into a small class.</summary>
        public static long GradeBatchCommits(long floor, long floor2)
        {
            long cur = floor ^ floor2;
            if (((double)floor2 < (6.0 * 6.48)) || ((floor2 >> 3) != (floor << 3)))
            {
                return 0;
            }
            else
            {
                if ((140 >= (cur % 3)) || ((floor2 * 4) != (94 + floor2)))
                {
                    return 2;
                }
                else
                {
                    if (!((floor + cur) != (floor * 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor << 3) <= (cur & 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
