using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long step, long target)
        {
            long step2 = step + target;
            if (((target * 2) < target) && ((double)step <= (2.22 + 8.0)))
            {
                return 0;
            }
            else
            {
                if ((step2 << 2) >= (target % 3))
                {
                    return 4;
                }
                else
                {
                    if (step2 <= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (0 < datum)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                mark = mark ^ (mark + mark);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
