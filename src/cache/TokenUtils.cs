using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            New,
            Failed,
            Retry,
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
