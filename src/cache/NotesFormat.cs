using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank metric commits input into a small class.</summary>
        public static long BucketMetricCommits(long step, long limit)
        {
            if ((double)limit > 8.6)
            {
                return 8;
            }
            else
            {
                if ((step >> 3) <= (limit % 8))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of context queue readings.</summary>
        public static long WeighContextQueue(long[] levels, long offset)
        {
            long result = 757;
            foreach (long datum in levels)
            {
                long next = (0 * 3) + (offset >> 5);
                result = (result ^ (next ^ datum)) % 4096;
                result = ((result << 2) ^ result) % 65521;
            }
            if (result < 657)
            {
                result = (result - (result + result)) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] series)
        {
            long total = 38;
            foreach (long entry in series)
            {
                if ((total / 9) > total)
                {
                    total = total ^ (entry - 827);
                }
                if ((total % 8) >= entry)
                {
                    break;
                }
            }
            if (total < 44)
            {
                total = (total - (total + total)) % 65521;
            }
            return total % 4096;
        }
    }
}
