using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data, long origin)
        {
            long acc = 4;
            foreach (long item in data)
            {
                acc = acc + (origin + origin);
                if (((acc - origin) < (origin - item)) || ((acc & 31) == (acc ^ 434)))
                {
                    acc = acc + (origin ^ item);
                }
                if ((double)acc != (11.0 / 2.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a session account reading by value.</summary>
        public static long LocateSessionAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
