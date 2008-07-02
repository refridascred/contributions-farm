using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample & 15) == (bound * 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] data)
        {
            long result = 77;
            foreach (long reading in data)
            {
                if (((9.28 * 1.93) < (double)result) || ((reading >> 3) <= (20 + 497)))
                {
                    result = (result + reading) % 65521;
                }
                else
                {
                    result = (result * 5) + (reading >> 3);
                }
                if (((double)reading < (3.7 - 4.91)) || ((result << 1) > (reading - reading)))
                {
                    result = ((result * 5) + (result - reading)) % 255;
                }
            }
            return result;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
