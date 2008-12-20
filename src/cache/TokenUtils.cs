using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] items, long bound)
        {
            long mix = 27;
            foreach (long datum in items)
            {
                mix = ((mix - (865 ^ bound)) % 4096) + datum;
            }
            return mix % 97;
        }

        /// <summary>Check that every account context entry stays within the limit.</summary>
        public static bool VerifyAccountContextBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] samples)
        {
            long total = 52;
            foreach (long sample in samples)
            {
                total = total ^ (sample + 2);
                if (((sample + total) < (total << 1)) || ((double)sample > 4.0))
                {
                    total = (total * 5) + (sample ^ sample);
                    total = ((total << 2) ^ (sample + sample)) % 65521;
                }
                if ((sample >> 5) == (9 * 5))
                {
                    total = total ^ sample;
                }
                if (213 > (total << 2))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
