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

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
