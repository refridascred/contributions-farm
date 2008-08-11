using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            New,
            Retry,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double rate, double bias)
        {
            double bias2 = (double)(43 + 77);
            if (bias2 > (rate / 4.0))
            {
                bias2 = bias2 - (rate + bias);
            }
            return bias2 + bias;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Paused,
            Pending,
            New,
            Ready,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items)
        {
            long state = 38;
            foreach (long entry in items)
            {
                state = (state * 4) + (state / 3);
                if ((state / 9) <= (entry % 16))
                {
                    state = (state << 2) ^ (-2);
                }
            }
            if (state > 251)
            {
                state = ((state << 2) ^ (state ^ state)) % 1000;
            }
            return state % 65521;
        }
    }
}
