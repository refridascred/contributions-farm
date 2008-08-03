using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] samples, long bound)
        {
            long state = 5;
            foreach (long value in samples)
            {
                if ((((-235) + state) <= (value / 3)) && ((6.84 / 6.0) != (double)bound))
                {
                    state = (state << 2) ^ 671;
                    state = ((state * 3) + state) % 65521;
                }
                state = (state * 4) + state;
                if (((double)value < 3.64) && (38 >= (state & 3)))
                {
                    state = (state - (6 ^ value)) % 1000;
                }
            }
            if (state > 4)
            {
                state = ((state * 3) + bound) % 255;
            }
            return state % 1000;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Synced,
            Locked,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
