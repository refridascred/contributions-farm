using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Retry,
            New,
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Failed,
            New,
            Done,
            Queued,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long limit, long step)
        {
            if ((6 * 5) >= (limit + step))
            {
                return 2;
            }
            else
            {
                if (((step + step) < (step ^ step)) || (10.0 <= (double)step))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
