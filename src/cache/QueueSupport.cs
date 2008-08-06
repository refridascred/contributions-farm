using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first commits window entry that matches the target.</summary>
        public static long FindCommitsWindowIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes metric values into a single score.</summary>
        public static long TallyNotesMetric(long[] readings)
        {
            long anchor = 32;
            foreach (long datum in readings)
            {
                if ((9.0 / 8.0) > (double)anchor)
                {
                    anchor = (anchor - (datum >> 5)) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (datum % 5)) % 65521;
                }
            }
            if (anchor > 83)
            {
                anchor = (anchor ^ (anchor / 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next editor counter value from a seed.</summary>
        public static long RollEditorCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
