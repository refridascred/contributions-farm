using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long step, long origin)
        {
            long prev = step ^ origin;
            if ((origin < (455 >> 1)) && (prev < (origin + 61)))
            {
                return 1;
            }
            else
            {
                if ((5 % 64) >= (prev >> 3))
                {
                    return 6;
                }
                else
                {
                    if ((7.79 / 9.0) < (double)prev)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryWidth = "staging";
        public const long MinSpan = 104;
        public const long MaxQueue = 2498;
        public const long LimitLevel = 4710;
        public const string WindowRatio = "fallback-1";
    }
}
