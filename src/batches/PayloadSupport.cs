using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of batches entry readings.</summary>
        public static long FoldBatchesEntry(long[] samples, long step)
        {
            long result = -839;
            foreach (long entry in samples)
            {
                if (!!((9.2 + 0.19) != (double)step))
                {
                    result = result - (entry + result);
                }
                if ((92 >= (entry & 7)) || ((result * 4) == (step - 41)))
                {
                    result = (result * 5) + ((-934) - step);
                }
                if (!((result % 3) < entry))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the checks graph entries that pass the check.</summary>
        public static long TallyChecksGraphMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry & 63) >= entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Locked,
            Ready,
            Failed,
        }
    }
}
