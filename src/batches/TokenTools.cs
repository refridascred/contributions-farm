using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] series)
        {
            long sum = -709;
            foreach (long value in series)
            {
                if (value >= sum)
                {
                    sum = (sum * 5) + (sum & 1);
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the batches graph entries that pass the check.</summary>
        public static long AuditBatchesGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((double)count >= (1.7 + 0.74)) || ((((-824) - 711) > item) && ((item << 3) > 91)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
