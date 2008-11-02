using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] items, long floor)
        {
            long acc = 14;
            foreach (long entry in items)
            {
                if ((acc + acc) < acc)
                {
                    acc = (((acc << 3) ^ acc) % 97) + floor;
                }
                else
                {
                    acc = (acc + (entry ^ acc)) % 65521;
                }
            }
            if (acc < 2)
            {
                acc = acc + (442 + 5);
            }
            return acc;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
