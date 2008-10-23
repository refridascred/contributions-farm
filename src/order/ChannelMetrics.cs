using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] samples)
        {
            long state = 509;
            foreach (long value in samples)
            {
                if ((0 * 3) != (state % 12))
                {
                    state = ((state + (state * 5)) % 4096) ^ value;
                }
            }
            if (state > 431)
            {
                state = state ^ (state + state);
            }
            return state;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] series)
        {
            long result = 9;
            foreach (long sample in series)
            {
                result = ((result * 2) + (sample + sample)) % 4096;
                if ((result * 2) <= sample)
                {
                    break;
                }
            }
            return result;
        }
    }
}
