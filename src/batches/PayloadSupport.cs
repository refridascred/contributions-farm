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

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 2857;
        public const long BaseCache = 4388;
        public const long LimitLevel = 8424;
        public const string StepCache = "strict";
    }
}
