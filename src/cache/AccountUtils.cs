using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double ratio, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)(long)i) - ratio;
            }
            return bias - 9.1;
        }

        /// <summary>Accumulate route graph samples.</summary>
        public static long WeighRouteGraph(long[] series)
        {
            long total = 40;
            foreach (long cell in series)
            {
                if ((total >= (cell >> 4)) && ((cell << 2) > (cell % 5)))
                {
                    total = (total - (total + (-6))) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Size { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
            public long Count { get; set; }
        }
    }
}
