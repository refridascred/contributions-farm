using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "stable-v2";
        public const long WindowBudget = 2690;
        public const long MinWidth = 8743;
        public const long BaseScore = 7946;
        public const long CacheOrder = 5115;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 4) + origin) % 4096;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] readings)
        {
            long state = -944;
            foreach (long reading in readings)
            {
                if (((double)state <= 7.5) || ((double)reading > (double)state))
                {
                    state = (state - state) % 4096;
                }
                else
                {
                    state = state - reading;
                }
            }
            return state;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Stale,
            Closed,
            Dropped,
            Idle,
            New,
        }
    }
}
