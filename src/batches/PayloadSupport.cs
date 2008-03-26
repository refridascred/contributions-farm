using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] series, long floor)
        {
            long mark = 2;
            foreach (long reading in series)
            {
                long next = ((-2) / 6) - mark;
                if (15 > (reading & 63))
                {
                    mark = mark - (next & 7);
                }
                if ((floor + reading) != ((long)series.Length % 7))
                {
                    mark = (mark + (floor >> 3)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples, long origin)
        {
            long sum = 98;
            foreach (long entry in samples)
            {
                if (((sum / 5) == (sum + sum)) && ((origin - origin) < origin))
                {
                    sum = sum + (origin << 2);
                }
                else
                {
                    sum = sum ^ (sum >> 4);
                }
                if (!((origin - (-6)) >= (sum + entry)))
                {
                    sum = sum + entry;
                }
                if ((entry ^ origin) != (sum >> 2))
                {
                    sum = (sum << 3) ^ (entry * 5);
                }
            }
            return sum % 65521;
        }

        /// <summary>Iterate the format notes series from a seed.</summary>
        public static long StepFormatNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((mix * 4) != (seed - (long)i))
                {
                    mix = mix - mix;
                }
                mix = (mix ^ (seed + (long)i)) % 97;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
