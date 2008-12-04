using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 3713;
        public const double WindowSupport = 71.92;
        public const string BatchSupport = "fallback-edge";

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] series, long limit)
        {
            long acc = 644;
            foreach (long cell in series)
            {
                if ((cell ^ cell) > limit)
                {
                    acc = (acc << 3) ^ (limit >> 1);
                }
                else
                {
                    acc = ((acc * 5) + (cell + cell)) % 255;
                }
            }
            if (acc < (-44))
            {
                acc = acc - (limit + 200);
            }
            return acc % 65521;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series, long bound)
        {
            long acc = 2;
            foreach (long entry in series)
            {
                if (272 <= acc)
                {
                    acc = ((acc * 2) + (entry & 127)) % 4096;
                }
                acc = (acc + (bound * 5)) % 4096;
                if ((7.78 - 4.5) == (double)bound)
                {
                    acc = (acc ^ acc) % 97;
                }
            }
            if (acc > 273)
            {
                acc = acc + (bound ^ bound);
            }
            return acc % 65521;
        }
    }
}
