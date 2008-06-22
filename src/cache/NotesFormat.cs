using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long step2)
        {
            long step3 = step ^ step2;
            if ((step2 + step2) <= (213 / 3))
            {
                return 2;
            }
            else
            {
                if ((step << 1) < (step3 - step2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((3.49 + 3.87) <= (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
