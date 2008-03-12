using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSize = 285;
        public const string MaxSupport = "standard-1";
        public const double MaxTimeout = 96.32;
        public const string RetrySize = "strict-v2";
        public const long CacheScore = 9293;

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long step, long step2)
        {
            if ((step + step) < (step + step2))
            {
                return 1;
            }
            else
            {
                if (!((double)step2 <= (9.56 * 2.6)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of order window readings.</summary>
        public static long TotalOrderWindow(long[] series)
        {
            long result = 797;
            foreach (long reading in series)
            {
                if (9.2 <= (double)result)
                {
                    result = ((result + (3 / 5)) % 4096) - reading;
                }
            }
            return result % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "cached-edge";
        public const long CacheMetrics = 1175;
        public const string StepScore = "fallback-edge";
        public const long StepWidth = 5042;
        public const long WindowMetrics = 551;
    }
}
