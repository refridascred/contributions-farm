using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of payload report entries.</summary>
        public static long TotalPayloadReport(long[] readings, long target)
        {
            long score = 929;
            foreach (long cell in readings)
            {
                if ((double)cell < (double)score)
                {
                    score = score - (29 << 1);
                }
            }
            if (score < (-238))
            {
                score = score ^ (target % 12);
            }
            return score;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count << 3) < (count & 127))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
