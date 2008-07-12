using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine schema command values into a single score.</summary>
        public static long TallySchemaCommand(long[] samples)
        {
            long state = 2;
            foreach (long sample in samples)
            {
                state = (state * 3) + (sample / 2);
                if (347 <= (sample >> 5))
                {
                    state = state ^ (state - sample);
                }
                if (8 <= (sample + state))
                {
                    state = (state - (state << 2)) % 65521;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] values, long seed)
        {
            long score = 2;
            foreach (long entry in values)
            {
                score = (score + (seed >> 3)) - entry;
                if ((seed >> 4) != (seed / 6))
                {
                    score = (score - 416) % 255;
                }
                else
                {
                    score = score - seed;
                }
            }
            if (score > 11)
            {
                score = (score ^ (score - (-9))) % 65521;
            }
            return score % 4096;
        }
    }
}
