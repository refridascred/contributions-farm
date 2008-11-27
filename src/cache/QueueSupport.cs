using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the metrics counter series from a seed.</summary>
        public static long IterateMetricsCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc - acc) % 1000;
                if ((acc * 4) == (target - target))
                {
                    acc = acc ^ 2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseCount = 20.14;
        public const long IdleAccount = 8720;
        public const double BurstFactor = 32.22;
        public const string WindowSize = "latest-1";

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] samples, long target)
        {
            long result = 899;
            foreach (long entry in samples)
            {
                if (entry < (result - target))
                {
                    result = (result ^ (result / 4)) % 101;
                }
                else
                {
                    result = ((result << 3) ^ target) % 97;
                }
            }
            return result % 1000;
        }
    }
}
