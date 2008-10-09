using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count metric notes pairs that satisfy a relation.</summary>
        public static long PairMetricNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry << 3) ^ (98 + carry)) % 65521;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 5) + (acc + (long)i)) % 97;
                if (acc <= (step << 1))
                {
                    acc = acc - (acc - 623);
                }
                acc = ((acc * 4) + 649) % 255;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ result) % 101;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
