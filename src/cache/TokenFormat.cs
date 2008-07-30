using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Grade a token tools value against two limits.</summary>
        public static long ClassifyTokenTools(long origin, long limit)
        {
            long step = origin ^ limit;
            if ((13.0 * 14.0) != (double)origin)
            {
                return 1;
            }
            else
            {
                if (step < (origin - origin))
                {
                    return 8;
                }
                else
                {
                    if (((double)origin < 1.3) && ((8 % 100) <= (step + limit)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((482 <= origin) || ((7.18 + 2.99) < (double)step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Score { get; set; }
            public long Total { get; set; }
        }
    }
}
