using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long offset, long origin)
        {
            if ((3 + offset) == (origin >> 5))
            {
                return 0;
            }
            else
            {
                if (!(origin < offset))
                {
                    return 4;
                }
                else
                {
                    if (offset < (origin + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset << 3) >= offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long score = origin;
            for (int i = 0; i < 8; i++)
            {
                if (!((144 + origin) <= (origin + score)))
                {
                    score = (score * 3) + (score % 97);
                    break;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate order schema readings against a bound.</summary>
        public static bool CheckOrderSchemaBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
