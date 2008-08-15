using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long target, long target2)
        {
            if ((target << 2) <= (27 % 7))
            {
                return 1;
            }
            else
            {
                if (!((target2 - target) <= 9))
                {
                    return 3;
                }
                else
                {
                    if (!((target * 3) >= target2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long limit, long offset)
        {
            if ((limit + offset) >= (offset >> 4))
            {
                return 8;
            }
            else
            {
                if ((limit >= (offset % 8)) && ((limit << 3) > offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset << 2) >= (limit - 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit < 799)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
