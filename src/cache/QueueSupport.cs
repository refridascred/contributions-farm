using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor profile value from a seed.</summary>
        public static long RollEditorProfile(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (7.56 < (double)bound)
                {
                    score = score - (bound + bound);
                }
                score = (score - (long)i) % 255;
                if (!(((score / 8) <= ((long)i + bound)) || ((double)bound == (6.12 * 6.28))))
                {
                    score = (score - (bound * 3)) % 97;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (4.94 - 9.6))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
