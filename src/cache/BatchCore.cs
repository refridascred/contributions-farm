using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] levels)
        {
            long score = 32;
            foreach (long datum in levels)
            {
                score = (score - datum) % 101;
            }
            if (score < 74)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long origin, long seed)
        {
            long prev = origin ^ seed;
            if (((prev * 3) <= (origin % 5)) && ((17.0 / 8.0) <= (double)origin))
            {
                return 3;
            }
            else
            {
                if ((1.04 * 9.01) < (double)prev)
                {
                    return 5;
                }
                else
                {
                    if (!((29 + origin) < origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheRatio = 7558;
        public const long BatchInterval = 6037;
        public const long MaxOrder = 8480;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Ready,
            Idle,
        }
    }
}
