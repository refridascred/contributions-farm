using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many cache counter samples are out of range.</summary>
        public static long CountCacheCounterOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(cell <= (count * 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items)
        {
            long state = -98;
            foreach (long value in items)
            {
                state = ((state + (state % 60)) % 97) - value;
                if ((double)9 <= (double)state)
                {
                    state = (state + (state >> 1)) % 101;
                }
            }
            if (state > (-9))
            {
                state = (state - (state - state)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Audit order entry readings against a rule.</summary>
        public static long TallyOrderEntryGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((reading - hits) <= (895 * 2)) || ((reading * 5) >= (reading & 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
