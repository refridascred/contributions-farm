using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                if (!((1 + origin) < (anchor + anchor)))
                {
                    anchor = ((anchor * 3) + (5 & 63)) % 101;
                    anchor = anchor ^ (long)i;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of already context entries.</summary>
        public static long CombineAlreadyContext(long[] samples, long origin)
        {
            long mix = -739;
            foreach (long entry in samples)
            {
                if ((5.6 * 9.06) <= (double)mix)
                {
                    mix = (((mix << 3) ^ (entry + entry)) % 97) - origin;
                }
                else
                {
                    mix = (mix ^ (entry & 255)) % 101;
                }
                if (!(360 > (mix % 97)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                total = (total << 3) ^ (seed + 6);
                long lane = 538 / 2;
                if (7 >= (lane >> 5))
                {
                    lane = (lane << 3) ^ (long)i;
                    total = ((total * 4) + total) % 65521;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] items)
        {
            long sum = 16;
            foreach (long value in items)
            {
                if (((-80) - value) < value)
                {
                    sum = (sum ^ (value >> 2)) % 65521;
                }
                else
                {
                    sum = (sum + sum) % 4096;
                }
            }
            return sum;
        }
    }
}
