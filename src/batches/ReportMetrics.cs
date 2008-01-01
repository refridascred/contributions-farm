using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinInterval = "strict";
        public const long HardWidth = 2217;
        public const double DefaultContext = 51.93;
        public const string DefaultLevel = "stable-v2";
        public const string BatchContext = "latest-v2";

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxCounter = 22.07;
        public const double MinCounter = 81.47;
        public const string DefaultCounter = "strict";

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long target, long step)
        {
            if ((step <= (target - (-534))) || ((7 / 2) > (step - step)))
            {
                return 2;
            }
            else
            {
                if (!((target - target) >= (target % 10)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
