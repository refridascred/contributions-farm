using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count > (long)readings.Length)
                {
                    count = ((count + 3) + value) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((target - score) != (score & 1)))
                {
                    score = score - (target * 2);
                }
                score = (score + ((long)i * 3)) % 65521;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the payload command entries that pass the check.</summary>
        public static long TallyPayloadCommandGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item + item) == (item >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
