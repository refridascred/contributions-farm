using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 51.7;
        public const long WindowCount = 2389;
        public const long DefaultEditor = 7055;
        public const long BaseEditor = 144;
        public const long SoftInterval = 4904;

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)target >= (13.0 + 2.9))
                {
                    mark = mark ^ (mark * 5);
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((mark & 3) <= (mark * 3)))
                {
                    mark = (mark * 5) + (37 ^ step);
                    mark = mark - mark;
                    break;
                }
                mark = (mark ^ ((long)i + step)) % 97;
                mark = (mark << 2) ^ 819;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] samples, long seed)
        {
            long mix = 7;
            foreach (long entry in samples)
            {
                mix = (mix + (506 + seed)) % 97;
                if ((entry + entry) != (727 ^ entry))
                {
                    mix = (mix << 3) ^ (mix >> 3);
                }
            }
            return mix % 4096;
        }
    }
}
