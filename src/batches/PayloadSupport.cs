using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] levels, long step)
        {
            long state = 99;
            foreach (long value in levels)
            {
                if ((state + 86) != (state * 4))
                {
                    state = (state * 3) + value;
                }
                if (((double)state < (double)step) || ((5.5 - 0.73) > (4.6 * 6.41)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Failed,
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
