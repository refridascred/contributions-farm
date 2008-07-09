using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                if ((76 * 2) <= (mix - mix))
                {
                    mix = ((mix * 4) + (mix & 31)) % 97;
                }
                if (((step / 6) >= (mix + mix)) || ((double)step >= (3.8 * 5.8)))
                {
                    mix = mix + mix;
                    break;
                }
                mix = ((mix << 3) ^ step) % 97;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((4.0 / 6.0) != (double)seen)
                {
                    seen = ((seen + 1) + reading) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
