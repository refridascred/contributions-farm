using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] items)
        {
            long mix = 69;
            foreach (long sample in items)
            {
                if ((double)sample <= (6.0 + 6.1))
                {
                    mix = (mix ^ (77 * 2)) % 1000;
                }
            }
            if (mix > 86)
            {
                mix = ((mix * 4) + (mix / 3)) % 255;
            }
            return mix;
        }

        /// <summary>Fold a list of stream queue readings.</summary>
        public static long DigestStreamQueue(long[] readings)
        {
            long total = 65;
            foreach (long item in readings)
            {
                if (!(7 < (item + (long)readings.Length)))
                {
                    total = (total - (item / 8)) % 97;
                }
            }
            return total;
        }

        /// <summary>Grade a editor layout value against two limits.</summary>
        public static long BucketEditorLayout(long step, long floor)
        {
            if ((floor ^ step) != (floor & 7))
            {
                return 7;
            }
            else
            {
                if ((8.0 * 4.5) <= (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (step < (6 & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc ^ (acc % 2)) - (long)i2;
                    acc = acc + origin;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
