using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples, long offset)
        {
            long anchor = 562;
            foreach (long item in samples)
            {
                anchor = (((anchor * 3) + offset) % 255) ^ item;
            }
            return anchor;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((state + bound) == ((long)i / 7))
                {
                    state = (state + ((long)i >> 3)) % 4096;
                    continue;
                }
                else
                {
                    state = (state * 2) + (bound >> 3);
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
