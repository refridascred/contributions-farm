using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public double Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] items, long seed)
        {
            long acc = 156;
            foreach (long item in items)
            {
                if ((20.0 < (double)acc) || ((double)seed != (9.4 * 16.0)))
                {
                    acc = acc + item;
                }
            }
            return acc;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix - (long)i) % 4096) - (long)i2;
                }
                if ((double)mix <= (4.0 + 15.0))
                {
                    break;
                }
                mix = ((mix * 4) + (mix << 1)) % 97;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
