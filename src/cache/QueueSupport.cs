using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long seed, long seed2)
        {
            long bound = seed - seed2;
            if ((seed << 2) >= seed)
            {
                return 3;
            }
            else
            {
                if (((seed2 ^ 602) == (seed / 6)) || (seed > (seed2 + bound)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] readings, long step)
        {
            long mix = 940;
            foreach (long cell in readings)
            {
                mix = (((mix << 3) ^ 9) % 65521) - cell;
                if ((double)mix <= (1.1 - 13.0))
                {
                    mix = (mix * 5) + (mix - step);
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Synced,
            Draft,
            New,
        }
    }
}
