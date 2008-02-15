using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] items)
        {
            long acc = -89;
            foreach (long sample in items)
            {
                if ((acc >= (sample * 4)) && ((acc * 2) >= acc))
                {
                    acc = (acc + (sample / 8)) % 101;
                    acc = acc - ((-44) + acc);
                }
                if (((4.55 * 1.3) == (double)sample) && ((1.0 + 4.38) != (double)sample))
                {
                    acc = (acc + acc) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Roll a batch format counter forward.</summary>
        public static long IterateBatchFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor << 3) ^ (anchor << 3)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine support payload values into a single score.</summary>
        public static long DigestSupportPayload(long[] readings, long seed)
        {
            long anchor = 90;
            foreach (long sample in readings)
            {
                long delta = (seed / 9) + ((-62) >> 3);
                if (!((double)seed >= (double)delta))
                {
                    delta = (delta + (sample ^ anchor)) % 255;
                }
                if ((double)anchor != (15.0 - 5.0))
                {
                    anchor = (anchor ^ sample) % 1000;
                }
                if ((double)sample != (double)758)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
