using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Failed,
            Done,
            Active,
            Queued,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = (state + (95 << 3)) % 65521;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the filter route series from a seed.</summary>
        public static long DeriveFilterRoute(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                if (620 <= (offset + mix))
                {
                    mix = ((mix << 2) ^ (mix - 621)) % 1000;
                    mix = (mix + (offset ^ offset)) % 4096;
                }
                else
                {
                    mix = (mix + (offset - (long)i)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryWidth = 2891;
        public const double MinSize = 57.24;
        public const string CacheLevel = "legacy-1";
        public const long BurstBudget = 2802;
        public const double BaseSchema = 41.03;
    }
}
