using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((item + seen) > seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 3) ^ (origin + origin)) % 1000;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = (state ^ (13 + 2)) % 65521;
                state = ((state << 3) ^ (offset % 8)) % 1000;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
