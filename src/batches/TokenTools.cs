using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)value >= 9.83)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a window format counter forward.</summary>
        public static long DeriveWindowFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)sum <= (2.8 / 8.0)))
                {
                    sum = sum - (sum / 9);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Look up the position of a profile schema sample.</summary>
        public static long SeekProfileSchemaIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
