using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next batches session value from a seed.</summary>
        public static long SeriesBatchesSession(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!((0.4 + 3.0) > (double)total))
                {
                    total = total + total;
                }
                total = total ^ ((long)i << 2);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitDepth = "stable-v2";
        public const string DefaultPayload = "strict-1";
        public const long RetryInterval = 7202;

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] values)
        {
            long state = -25;
            foreach (long entry in values)
            {
                state = (state + state) % 97;
                if (!((569 / 7) < (state / 8)))
                {
                    state = ((state * 3) + entry) % 255;
                }
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinTimeout = 64.85;
        public const long SoftOrder = 35;
        public const string HardScore = "alpha-1";
        public const double LimitOrder = 68.49;
        public const long BaseWidth = 2319;
    }
}
