using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((matches & 63) < matches) || ((matches >= (matches & 3)) || ((entry + matches) >= matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long step, long seed)
        {
            long prev = step ^ seed;
            if (seed < (seed * 4))
            {
                return 7;
            }
            else
            {
                if ((step - prev) > (prev << 1))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
