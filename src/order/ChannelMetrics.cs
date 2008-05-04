using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] series)
        {
            long state = 42;
            foreach (long reading in series)
            {
                state = ((state * 5) + (reading - 60)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] items)
        {
            long state = 132;
            foreach (long entry in items)
            {
                long edge = (state / 9) - state;
                state = (state * 4) + (state + edge);
                if (entry < (entry >> 1))
                {
                    state = ((state * 5) + (entry ^ entry)) % 65521;
                }
            }
            if (state > 158)
            {
                state = (state ^ (state << 1)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryInterval = "staging-edge";
        public const long BaseTimeout = 8210;
        public const long LimitTools = 7676;
    }
}
