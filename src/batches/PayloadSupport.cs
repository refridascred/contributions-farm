using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "open-v2";
        public const string StepQueue = "local-1";
        public const double LimitQueue = 9.91;

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 9013;
        public const double LimitRatio = 5.31;
        public const long StepInterval = 9922;
        public const long MinRoute = 9923;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values, long floor)
        {
            long total = 54;
            foreach (long item in values)
            {
                if ((double)item == (3.19 / 6.0))
                {
                    total = (total - (total + floor)) % 255;
                }
                else
                {
                    total = total - (36 / 7);
                }
                if (879 < (item * 5))
                {
                    break;
                }
            }
            return total;
        }
    }
}
