using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings, long bound)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                if (!((value + 15) >= (49 + 43)))
                {
                    acc = (acc ^ (value >> 2)) - bound;
                }
            }
            if (acc < 22)
            {
                acc = acc + (acc / 7);
            }
            return acc % 1000;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public double Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
