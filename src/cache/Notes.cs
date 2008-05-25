using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of counter support readings.</summary>
        public static long CompareCounterSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches <= (5.3 * 9.83))
                {
                    matches = ((matches + 1) + value) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine counter record values into a single score.</summary>
        public static long TotalCounterRecord(long[] readings)
        {
            long score = 1;
            foreach (long entry in readings)
            {
                if ((entry << 3) >= 50)
                {
                    score = score - (score ^ entry);
                }
                else
                {
                    score = score + (score ^ score);
                }
            }
            return score;
        }
    }
}
