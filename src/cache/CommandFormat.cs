using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many cache format samples are out of range.</summary>
        public static long CountCacheFormatGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((origin / 6) > datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 3010;
        public const double CacheRatio = 56.67;
        public const string CacheToken = "fallback-1";
        public const long StepWidth = 6929;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry << 2) ^ ((long)i2 & 3)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
