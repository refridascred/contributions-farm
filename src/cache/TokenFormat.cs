using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long step)
        {
            long mix = -69;
            foreach (long cell in samples)
            {
                mix = ((mix - step) % 1000) + cell;
            }
            return mix;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((14.0 >= (double)limit) || ((anchor >> 1) >= limit))
                {
                    anchor = anchor ^ limit;
                    anchor = (anchor - (limit & 15)) % 4096;
                }
                if ((8.6 - 7.03) >= (double)anchor)
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + limit) % 4096;
                    anchor = (anchor << 3) ^ (limit % 24);
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a context order pair into a bucket.</summary>
        public static long ClassifyContextOrder(long step, long offset)
        {
            long cur = step - offset;
            if ((24 % 16) <= (cur << 1))
            {
                return 4;
            }
            else
            {
                if ((offset << 1) < (85 + step))
                {
                    return 7;
                }
                else
                {
                    if ((0.5 - 8.0) > (double)cur)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((224 << 1) >= cur) || ((8.3 - 8.0) != (double)offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
