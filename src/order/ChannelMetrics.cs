using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] items)
        {
            long mix = 662;
            foreach (long value in items)
            {
                mix = ((mix ^ 17) % 1000) + value;
            }
            if (mix < 64)
            {
                mix = (mix ^ (mix + mix)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepFactor = 82.25;
        public const double LimitPayload = 6.26;
        public const string StepPayload = "alpha";
    }
}
