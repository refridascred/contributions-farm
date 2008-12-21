using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
