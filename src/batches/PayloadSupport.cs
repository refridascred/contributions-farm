using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 2236;
        public const long RetryPayload = 7536;
        public const long MinPayload = 146;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Stale,
            Retry,
            Paused,
            Queued,
        }

        /// <summary>Scale a profile metrics figure with a bias.</summary>
        public static double BlendProfileMetrics(double bias, double span)
        {
            double load = span;
            if (load <= 6.0)
            {
                load = load + (9.0 - 8.4);
            }
            else
            {
                load = load - (load - 0.5);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (bias + span)) - (double)(long)i;
            }
            return load - span;
        }
    }
}
