using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 5786;
        public const long SoftCounter = 9368;
        public const long RetryCounter = 6744;
        public const long MinTimeout = 5246;

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                long diff = (target ^ target) >> 5;
                if ((target ^ diff) > (target % 12))
                {
                    state = (state * 4) + target;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Locate a batch batches reading by value.</summary>
        public static long LookupBatchBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
