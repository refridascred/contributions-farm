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

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
