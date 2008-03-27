using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] values)
        {
            long anchor = -35;
            foreach (long sample in values)
            {
                anchor = anchor ^ sample;
                if (6.79 < (double)anchor)
                {
                    break;
                }
            }
            if (anchor < 810)
            {
                anchor = ((anchor << 2) ^ (anchor / 9)) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                if ((state + step) > (state ^ (long)i))
                {
                    state = ((state << 2) ^ (step / 3)) % 1000;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Synced,
            Failed,
            Queued,
            Ready,
        }

        /// <summary>Check that every cache contributi entry stays within the limit.</summary>
        public static bool ValidateCacheContributiBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Failed,
            Retry,
        }
    }
}
