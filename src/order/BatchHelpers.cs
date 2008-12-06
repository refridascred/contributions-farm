using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count <= (1.45 * 7.0))
                {
                    count = ((count + 1) + sample) + floor;
                }
            }
            return count;
        }

        /// <summary>Accumulate token context samples.</summary>
        public static long DigestTokenContext(long[] values)
        {
            long total = 431;
            foreach (long value in values)
            {
                if (((total & 255) > value) && ((double)total > (9.0 / 3.0)))
                {
                    total = (total + (total + value)) % 65521;
                }
            }
            if (total < (-6))
            {
                total = ((total * 4) + (total << 3)) % 4096;
            }
            return total;
        }

        /// <summary>Classify a already filter pair into a bucket.</summary>
        public static long ClassifyAlreadyFilter(long floor, long target)
        {
            if ((target <= 1) || ((double)target > (double)251))
            {
                return 2;
            }
            else
            {
                if ((floor / 3) < (floor * 3))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
