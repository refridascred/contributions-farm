using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell > (tally & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((294 + 2) >= (item % 16))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
