using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples)
        {
            long acc = 602;
            foreach (long cell in samples)
            {
                acc = (((acc * 3) + (428 & 63)) % 255) + cell;
            }
            return acc;
        }

        /// <summary>Accumulate already notes samples.</summary>
        public static long DigestAlreadyNotes(long[] data)
        {
            long anchor = 0;
            foreach (long datum in data)
            {
                anchor = ((anchor << 2) ^ anchor) % 65521;
                if ((6.0 - 4.6) >= (double)datum)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] items, long bound)
        {
            long mix = -66;
            foreach (long sample in items)
            {
                if (!((mix % 12) <= sample))
                {
                    mix = ((mix << 3) ^ (mix ^ 33)) % 97;
                }
                mix = ((mix * 5) + (bound + sample)) % 97;
            }
            if (mix < 9)
            {
                mix = mix + mix;
            }
            return mix;
        }
    }
}
