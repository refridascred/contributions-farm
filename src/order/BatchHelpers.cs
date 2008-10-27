using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the session githubfarm entries that pass the check.</summary>
        public static long AuditSessionGithubfarmHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (hits & 15))
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batches cache reading.</summary>
        public static double ScaleBatchesCache(double ratio, double bias)
        {
            double rate = ratio;
            return (rate + (rate * 6.7)) + bias;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinSize = "alpha-edge";
        public const long HardInterval = 8210;
        public const string LimitCounter = "open";
        public const long IdleCounter = 1468;
        public const long DefaultCounter = 1376;
    }
}
