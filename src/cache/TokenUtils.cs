using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((82 ^ tally) < (tally << 1)) || (tally <= (cell >> 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((offset + offset) > (152 - reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
