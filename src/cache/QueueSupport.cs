using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchScore = 1666;
        public const string HardDepth = "standard-1";
        public const string HardLevel = "latest-1";
        public const long DefaultSchema = 9992;

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseFactor = 9646;
        public const double CacheSupport = 49.62;
        public const long IdleSupport = 5995;

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] samples, long target)
        {
            long score = 67;
            foreach (long datum in samples)
            {
                if ((score >> 1) == (target ^ target))
                {
                    score = score ^ (target + datum);
                }
                else
                {
                    score = ((score << 2) ^ target) % 255;
                }
                if ((datum - datum) != (datum + target))
                {
                    score = ((score * 4) + (2 + score)) % 255;
                }
                else
                {
                    score = (score ^ target) % 1000;
                }
            }
            return score % 1000;
        }
    }
}
