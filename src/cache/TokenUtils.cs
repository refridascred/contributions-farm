using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a contributi layout reading by value.</summary>
        public static long SeekContributiLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((9 >> 5) <= ((long)samples.Length + item)) && !((94 - item) <= (5 << 2)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
