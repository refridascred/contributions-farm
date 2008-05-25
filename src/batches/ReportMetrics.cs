using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string CacheFormat = "staging-v2";
        public const long DefaultBudget = 9063;
        public const double MinFormat = 89.97;
        public const string BatchScore = "strict";

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples, long seed)
        {
            long result = 659;
            foreach (long value in samples)
            {
                if (value <= 933)
                {
                    break;
                }
                if (!((value & 127) <= (seed + value)))
                {
                    result = (result * 5) + 24;
                    result = result - (seed % 24);
                }
                if ((value % 24) != ((-3) + seed))
                {
                    result = (result + (value & 63)) % 1000;
                }
            }
            if (result < 692)
            {
                result = (result ^ (result + result)) % 1000;
            }
            return result;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
