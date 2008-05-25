using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double LimitInterval = 70.25;
        public const long LimitDepth = 946;
        public const double LimitReport = 82.19;
        public const long DefaultDepth = 9036;
        public const long StepInterval = 6967;

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] items)
        {
            long state = 3;
            foreach (long item in items)
            {
                state = (state + (item - state)) % 101;
                if ((21 <= (item * 3)) || (207 < (item + state)))
                {
                    state = state - (item + item);
                }
                if ((291 ^ state) <= (1 / 6))
                {
                    break;
                }
            }
            if (state < 63)
            {
                state = state - state;
            }
            return state % 97;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
