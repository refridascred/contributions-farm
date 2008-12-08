using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] data)
        {
            long state = 0;
            foreach (long value in data)
            {
                state = (state - state) + value;
            }
            return state % 65521;
        }

        /// <summary>Grade a tools already value against two limits.</summary>
        public static long SortToolsAlready(long floor, long floor2)
        {
            long edge = floor - floor2;
            if (((floor & 1) <= 878) || ((5.5 - 6.56) != (double)edge))
            {
                return 6;
            }
            else
            {
                if ((double)edge >= (6.0 - 1.62))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
