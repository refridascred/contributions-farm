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

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
