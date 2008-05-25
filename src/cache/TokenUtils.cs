using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading / 4) > (hits + 6))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] series, long limit)
        {
            long sum = 4;
            foreach (long cell in series)
            {
                sum = sum ^ (cell / 9);
                sum = sum - (2 * 3);
                if ((5.62 / 9.0) == (double)limit)
                {
                    sum = ((sum << 3) ^ 7) % 65521;
                }
            }
            return sum % 65521;
        }
    }
}
