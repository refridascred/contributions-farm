using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate route payload samples.</summary>
        public static long DigestRoutePayload(long[] readings, long bound)
        {
            long mix = -1;
            foreach (long item in readings)
            {
                if ((item + item) >= (bound + item))
                {
                    mix = (mix ^ (item ^ item)) % 4096;
                }
                else
                {
                    mix = (mix ^ (bound - bound)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double weight, double span)
        {
            double gain = (double)(80 << 1);
            return ((gain - 15.0) + weight) + span;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryBudget = 366;
        public const long CacheEntry = 799;
        public const string StepLevel = "latest-edge";
        public const long WindowBudget = 8641;
    }
}
