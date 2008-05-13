using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((11.0 / 4.0) <= (double)tally)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
