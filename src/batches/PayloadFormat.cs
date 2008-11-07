using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 2745;
        public const string StepBudget = "strict";
        public const long SoftCache = 1996;
        public const long MaxTimeout = 3784;
        public const long StepLevel = 5519;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Locked,
            Idle,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] series, long limit)
        {
            long acc = 3;
            foreach (long datum in series)
            {
                if (!((13.0 * 18.0) == (double)acc))
                {
                    acc = (((acc * 4) + (3 - datum)) % 255) + limit;
                }
                if (((datum >> 3) == (datum / 3)) && (13.0 < (double)(long)series.Length))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 2103;
        public const long BatchChannel = 1600;
        public const long SoftWidth = 5157;
        public const long LimitSpan = 2493;
        public const long IdleChannel = 2487;
    }
}
