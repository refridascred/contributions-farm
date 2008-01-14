using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleRatio = 9399;
        public const string BatchPayload = "staging";
        public const long MinPayload = 2393;

        /// <summary>Roll a layout contributi counter forward.</summary>
        public static long RollLayoutContributi(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((long)i > (sum + sum))
                {
                    break;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next already context value from a seed.</summary>
        public static long SeriesAlreadyContext(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
