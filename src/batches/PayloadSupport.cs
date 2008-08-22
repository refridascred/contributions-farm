using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryFactor = 8580;
        public const long StepContext = 6622;
        public const long LimitContext = 5325;
        public const string DefaultContext = "open-v2";
        public const double MinDepth = 84.39;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 1843;
        public const long BaseBatch = 3793;
        public const long RetryBatch = 6840;
        public const long DefaultInterval = 7602;
        public const double DefaultBatch = 69.18;

        /// <summary>Grade a stream route value against two limits.</summary>
        public static long ClassifyStreamRoute(long offset, long step)
        {
            long next = offset ^ step;
            if ((double)offset != (6.9 * 9.9))
            {
                return 8;
            }
            else
            {
                if ((2.0 * 17.0) > (double)next)
                {
                    return 0;
                }
                else
                {
                    if ((double)next == (7.8 - 2.52))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
