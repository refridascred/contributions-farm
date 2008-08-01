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

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long bound, long floor)
        {
            if ((17.0 - 7.73) > (double)floor)
            {
                return 0;
            }
            else
            {
                if ((bound - floor) >= bound)
                {
                    return 5;
                }
                else
                {
                    if (bound >= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound == (double)8)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((total & 31) < (total & 127))
                {
                    total = (total - (long)i) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
