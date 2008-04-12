using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((hits + bound) != (bound & 31)))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the queue batches entries that pass the check.</summary>
        public static long MeasureQueueBatchesMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((bound - (-10)) != (reading & 255)) && ((4.86 + 8.59) > (double)count)) && !((count - count) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] readings, long bound)
        {
            long total = 920;
            foreach (long sample in readings)
            {
                if ((double)sample > 4.0)
                {
                    total = total + bound;
                    total = (total << 2) ^ ((long)readings.Length >> 3);
                }
                else
                {
                    total = (total - (bound % 3)) % 97;
                }
                if (bound <= total)
                {
                    total = (total << 2) ^ total;
                }
            }
            return total;
        }
    }
}
