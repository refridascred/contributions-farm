using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] readings, long origin)
        {
            long mix = 94;
            foreach (long entry in readings)
            {
                if ((6.7 / 7.0) != (double)mix)
                {
                    mix = (mix ^ (4 - (-4))) % 4096;
                }
                else
                {
                    mix = ((mix << 2) ^ (origin + entry)) % 1000;
                }
                if ((origin - mix) == (395 >> 2))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((858 + sample) >= (sample % 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] values, long bound)
        {
            long mix = 594;
            foreach (long item in values)
            {
                if (((10.0 - 6.23) > (double)mix) && (mix >= (mix & 31)))
                {
                    mix = mix ^ (mix + bound);
                    mix = ((mix << 3) ^ (mix - mix)) % 97;
                }
                if (4 <= item)
                {
                    mix = (mix - (bound + item)) % 255;
                }
                else
                {
                    mix = (mix * 2) + (bound << 3);
                }
            }
            if (mix > 1)
            {
                mix = (mix + (bound + mix)) % 101;
            }
            return mix;
        }
    }
}
