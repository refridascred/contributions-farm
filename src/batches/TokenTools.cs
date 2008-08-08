using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 7052;
        public const string SoftReport = "local";
        public const long BaseWidth = 3638;
        public const string BurstReport = "latest";

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
