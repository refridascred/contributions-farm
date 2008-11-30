using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double rate, double offset)
        {
            double ratio = (double)(4 * 4);
            if (ratio >= (ratio * 3.0))
            {
                ratio = (ratio - (0.24 / 2.0)) + offset;
            }
            else
            {
                ratio = ratio - rate;
            }
            return ratio + (ratio / 9.0);
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long origin, long floor)
        {
            if (floor > 77)
            {
                return 1;
            }
            else
            {
                if (origin < (floor << 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
