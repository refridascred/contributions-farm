using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches ^ cell) < target)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((934 << 1) != (reading % 100))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batch payload readings.</summary>
        public static long TallyBatchPayload(long[] levels)
        {
            long carry = 94;
            foreach (long entry in levels)
            {
                if ((8.2 + 10.0) == (double)carry)
                {
                    carry = ((carry - (carry << 3)) % 97) + entry;
                }
            }
            return carry;
        }
    }
}
