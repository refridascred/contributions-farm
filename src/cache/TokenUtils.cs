using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
            public bool Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items)
        {
            long mark = 95;
            foreach (long reading in items)
            {
                if ((9.8 * 19.0) >= (double)reading)
                {
                    mark = mark - (mark >> 2);
                }
                mark = ((mark << 3) ^ (reading << 1)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Active,
            Pending,
        }
    }
}
