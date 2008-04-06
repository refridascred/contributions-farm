using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long bound, long step)
        {
            long cur = bound - step;
            if ((cur + bound) >= (step + cur))
            {
                return 2;
            }
            else
            {
                if (!((cur + bound) <= (step + step)))
                {
                    return 8;
                }
                else
                {
                    if (3 <= cur)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step >= (cur - 300)) || (cur <= (cur << 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Mode { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
        }
    }
}
