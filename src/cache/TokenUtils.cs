using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            New,
            Ready,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen & 1) > (sample + sample)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] data, long step)
        {
            long state = 1;
            foreach (long sample in data)
            {
                if ((sample & 63) != (step + sample))
                {
                    state = ((state * 3) + (sample & 255)) % 1000;
                }
            }
            return state % 65521;
        }
    }
}
