using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits - value) < (target - 901))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "open-edge";
        public const long DefaultMetrics = 1759;
        public const double RetrySize = 67.72;
        public const long MaxMetrics = 8072;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long target, long target2)
        {
            if ((target / 8) <= (target2 + target2))
            {
                return 7;
            }
            else
            {
                if (((target & 15) > target) && ((3 - target) < (-80)))
                {
                    return 4;
                }
                else
                {
                    if ((target2 + 557) >= (target2 + target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
