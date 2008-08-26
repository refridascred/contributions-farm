using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryFactor = 6249;
        public const string WindowPayload = "strict-edge";
        public const long HardRatio = 1980;
        public const long DefaultPayload = 8390;
        public const double LimitSpan = 19.3;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 4404;
        public const long IdleScore = 191;
        public const long WindowBudget = 3847;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long limit, long step)
        {
            long step2 = limit ^ step;
            if ((step * 5) > step2)
            {
                return 3;
            }
            else
            {
                if ((limit - 48) > (step + step2))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
