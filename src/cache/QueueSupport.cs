using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) == (hits >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank command commits input into a small class.</summary>
        public static long GradeCommandCommits(long origin, long floor)
        {
            long cur = origin ^ floor;
            if (((origin * 3) >= origin) && ((origin + floor) > cur))
            {
                return 4;
            }
            else
            {
                if ((cur / 8) < (364 - floor))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
