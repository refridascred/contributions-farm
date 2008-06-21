using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double weight, double span)
        {
            double ratio = weight;
            if (ratio >= 3.31)
            {
                ratio = (ratio + (ratio - 9.17)) + span;
            }
            else
            {
                ratio = ratio + (double)546;
            }
            return ratio + (ratio * 18.0);
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long offset)
        {
            long result = 438;
            foreach (long datum in samples)
            {
                if (result >= (result >> 2))
                {
                    result = ((result - offset) % 4096) + datum;
                }
            }
            return result % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstWidth = 8383;
        public const long CacheQueue = 4297;
        public const double LimitQueue = 11.54;
        public const long HardQueue = 6455;
        public const long IdleDepth = 5493;
    }
}
