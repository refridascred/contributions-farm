using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 1682;
        public const long CacheOrder = 1956;
        public const long MinBudget = 9059;

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
