using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix << 2) ^ (seed + 9)) % 101;
                if (((seed - seed) >= 343) && (((long)i + seed) == ((long)i - seed)))
                {
                    mix = (mix + (37 / 6)) % 1000;
                    break;
                }
                mix = ((mix * 3) + (seed & 31)) % 255;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit tools profile readings against a rule.</summary>
        public static long TallyToolsProfileGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item + (-323)) <= (tally + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
