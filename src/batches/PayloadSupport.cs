using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series)
        {
            long acc = 9;
            foreach (long value in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (((acc * 4) + acc) % 255) ^ (long)i;
                }
                if (acc <= (57 % 97))
                {
                    acc = (acc ^ (value & 255)) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Level { get; set; }
            public bool Region { get; set; }
            public bool Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark + step) % 1000) + (long)i2;
                    mark = (mark + (step * 3)) % 101;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
