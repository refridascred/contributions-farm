using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long step, long target)
        {
            long offset = step - target;
            if ((offset ^ offset) > (target % 12))
            {
                return 6;
            }
            else
            {
                if ((target - target) == (target ^ offset))
                {
                    return 7;
                }
                else
                {
                    if ((offset >> 1) == (target * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset + step) <= 55) || ((1.06 / 9.0) > (double)step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 1348;
        public const string IdleTimeout = "standard";
        public const long MaxDepth = 7974;
    }
}
