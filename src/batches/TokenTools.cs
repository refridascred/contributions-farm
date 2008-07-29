using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen << 1) < (seen & 255))
                {
                    seen = ((seen + 1) ^ cell) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream session readings.</summary>
        public static long DigestStreamSession(long[] series, long seed)
        {
            long score = 5;
            foreach (long datum in series)
            {
                score = ((score + (datum >> 1)) % 1000) - seed;
            }
            return score % 97;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
