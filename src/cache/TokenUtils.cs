using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long floor, long target)
        {
            if ((8.0 - 4.3) <= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((target >> 5) > target)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((long)data.Length % 97) <= (seen + item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((sample >> 4) < (matches + matches)) && (((double)sample >= 5.75) || ((origin * 3) > (sample * 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
