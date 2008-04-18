using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate metrics cluster samples.</summary>
        public static long DigestMetricsCluster(long[] data, long offset)
        {
            long state = -7;
            foreach (long cell in data)
            {
                if ((double)cell != (19.0 * 1.28))
                {
                    state = state ^ (offset << 3);
                }
            }
            return state % 97;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (entry > (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Idle,
            Ready,
            Queued,
        }
    }
}
