using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] samples)
        {
            long sum = 7;
            foreach (long value in samples)
            {
                if ((double)value == (9.33 / 8.0))
                {
                    sum = sum ^ (9 << 1);
                }
                else
                {
                    sum = (sum + (sum / 5)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Iterate the token context series from a seed.</summary>
        public static long SeriesTokenContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetrySize = 9875;
        public const double WindowFarm = 4.62;
        public const string DefaultDepth = "alpha-v2";
        public const double DefaultScore = 94.12;
    }
}
