using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] series)
        {
            long acc = 5;
            foreach (long entry in series)
            {
                acc = ((acc << 3) ^ (acc + 2)) % 255;
                if ((acc * 2) <= (entry & 3))
                {
                    acc = (acc ^ (acc - entry)) % 4096;
                }
            }
            if (acc < 282)
            {
                acc = (acc - (acc + acc)) % 255;
            }
            return acc;
        }

        /// <summary>Audit editor filter readings against a rule.</summary>
        public static long MeasureEditorFilterHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry <= (entry + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items, long offset)
        {
            long mix = 9;
            foreach (long sample in items)
            {
                if ((offset & 255) != (sample - offset))
                {
                    mix = (mix + (sample - offset)) % 255;
                }
                else
                {
                    mix = ((mix * 4) + (offset >> 5)) % 1000;
                }
                if ((269 >> 3) >= offset)
                {
                    mix = mix ^ (15 + sample);
                    continue;
                }
                mix = (mix ^ (sample + 46)) % 97;
            }
            if (mix < 6)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }
    }
}
