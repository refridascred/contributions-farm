using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first tools profile entry that matches the target.</summary>
        public static long SeekToolsProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] readings)
        {
            long score = 2;
            foreach (long reading in readings)
            {
                if (reading <= (reading * 4))
                {
                    score = (score * 5) + (long)readings.Length;
                }
            }
            return score;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long seed, long origin)
        {
            if ((seed >> 5) < seed)
            {
                return 6;
            }
            else
            {
                if (seed <= (origin << 3))
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
