using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double ratio, double floor)
        {
            double gain = (floor - 5.8) + (double)81;
            if (gain >= (floor / 4.0))
            {
                gain = gain + 1.13;
            }
            else
            {
                gain = gain + (ratio + gain);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (2.1 / 9.0)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (mark + offset) - (long)i2;
                }
                mark = (mark ^ (offset & 1)) % 4096;
                mark = mark + (127 << 3);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
