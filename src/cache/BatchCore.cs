using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] values, long limit)
        {
            long anchor = 477;
            foreach (long cell in values)
            {
                if (!((8 - (long)values.Length) >= anchor))
                {
                    anchor = ((anchor - (limit + anchor)) % 65521) + cell;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 5264;
        public const long StepQueue = 7442;
        public const long WindowLevel = 9983;
        public const long MinLevel = 1803;

        /// <summary>Accumulate support filter samples.</summary>
        public static long DigestSupportFilter(long[] values, long origin)
        {
            long state = -9;
            foreach (long value in values)
            {
                if ((double)state <= (5.5 / 8.0))
                {
                    state = ((state + origin) % 1000) ^ value;
                }
            }
            return state;
        }
    }
}
