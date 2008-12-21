using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
