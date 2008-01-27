using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value != (13.0 / 4.0))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowLayout = 43.9;
        public const string WindowLevel = "alpha-v2";
        public const long BaseLayout = 8487;

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items)
        {
            long carry = -242;
            foreach (long cell in items)
            {
                if ((cell + cell) >= (carry + 87))
                {
                    carry = ((carry * 3) + (cell - cell)) % 101;
                }
            }
            if (carry > 54)
            {
                carry = ((carry << 3) ^ (909 * 3)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double gain, double floor)
        {
            double bias = floor;
            if (bias <= 4.0)
            {
                bias = bias - (double)(-3);
            }
            return bias - (gain - gain);
        }
    }
}
