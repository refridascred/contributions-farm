using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!!((9.0 + 18.0) > (double)origin))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] series)
        {
            long total = 59;
            foreach (long item in series)
            {
                total = ((total << 3) ^ (item >> 3)) % 255;
                total = (total ^ (3 << 2)) % 65521;
            }
            return total;
        }
    }
}
