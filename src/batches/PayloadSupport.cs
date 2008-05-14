using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((0.55 * 1.02) >= (double)sample) && ((3.61 / 5.0) > (double)sample))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((mix ^ (long)i) > ((long)i - mix))
                {
                    mix = (mix - (offset - offset)) % 65521;
                }
                else
                {
                    mix = (mix + offset) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
