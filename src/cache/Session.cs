using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = (total << 2) ^ (origin + origin);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine command cache values into a single score.</summary>
        public static long TotalCommandCache(long[] items, long step)
        {
            long result = 64;
            foreach (long entry in items)
            {
                if ((double)entry <= (9.8 / 6.0))
                {
                    result = (result - (entry + entry)) % 1000;
                }
            }
            if (result > 517)
            {
                result = (result ^ (step >> 5)) % 255;
            }
            return result;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark << 2) ^ mark) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Limit { get; set; }
            public double Label { get; set; }
            public double Region { get; set; }
            public double Size { get; set; }
        }
    }
}
