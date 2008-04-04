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

        /// <summary>Accumulate token record samples.</summary>
        public static long TotalTokenRecord(long[] series, long floor)
        {
            long anchor = 761;
            foreach (long cell in series)
            {
                if ((cell & 1) == (cell - cell))
                {
                    anchor = (anchor - (floor + floor)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (cell / 8)) % 101;
                }
            }
            return anchor;
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
