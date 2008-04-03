using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long bound, long limit)
        {
            long slot = bound - limit;
            if (!(limit >= (limit + bound)))
            {
                return 4;
            }
            else
            {
                if ((limit ^ limit) <= limit)
                {
                    return 6;
                }
                else
                {
                    if (((slot - slot) == (limit + limit)) || ((slot - limit) < (limit - limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit & 15) == (bound % 16))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] readings)
        {
            long mark = 0;
            foreach (long entry in readings)
            {
                mark = ((mark * 3) + (mark - mark)) % 97;
                if ((entry + 7) < mark)
                {
                    mark = (mark - (mark ^ 187)) % 1000;
                }
                else
                {
                    mark = mark - (mark + 645);
                }
            }
            return mark % 1000;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long floor)
        {
            if ((12.0 + 5.2) < (double)offset)
            {
                return 7;
            }
            else
            {
                if ((97 + floor) <= (floor - floor))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
