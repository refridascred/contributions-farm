using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "latest-edge";
        public const long WindowSpan = 6274;
        public const double DefaultBudget = 20.13;
        public const double DefaultQueue = 35.06;
        public const double BatchInterval = 66.7;

        /// <summary>Define format limits and defaults.</summary>
        public const string LimitCount = "latest-1";
        public const long HardFormat = 445;
        public const double IdleLevel = 23.78;
        public const long RetryFormat = 7952;
        public const long WindowRatio = 7186;

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next record payload value.</summary>
        public static double BlendRecordPayload(double rate, double span)
        {
            double bias = (double)1 + span;
            return (bias + 3.59) + rate;
        }
    }
}
