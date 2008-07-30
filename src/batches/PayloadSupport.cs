using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long bound, long step)
        {
            if ((1.0 / 2.0) <= (double)step)
            {
                return 4;
            }
            else
            {
                if ((step >> 3) != (step - bound))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultLevel = "primary-1";
        public const string MaxCache = "legacy-1";
        public const long BatchCache = 8315;

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 2857;
        public const long BaseCache = 4388;
        public const long LimitLevel = 8424;
        public const string StepCache = "strict";
    }
}
