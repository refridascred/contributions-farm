using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of token support entries.</summary>
        public static long CombineTokenSupport(long[] series, long floor)
        {
            long score = 8;
            foreach (long value in series)
            {
                score = ((score << 2) ^ (score >> 1)) - value;
                score = score ^ (floor << 3);
            }
            if (score > 96)
            {
                score = score - (score + score);
            }
            return score % 65521;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long origin, long step)
        {
            if ((origin - step) > (59 >> 4))
            {
                return 5;
            }
            else
            {
                if ((24 % 2) <= (origin - step))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 5290;
        public const double CacheInterval = 92.0;
        public const long CacheLevel = 514;
    }
}
