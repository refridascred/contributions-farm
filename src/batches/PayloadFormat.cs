using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Dropped,
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 9066;
        public const long DefaultDepth = 2692;
        public const double RetryScore = 9.83;
        public const long LimitBudget = 5233;
        public const long DefaultWidth = 84;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((floor - hits) == (sample + 53))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long bound, long step)
        {
            if (!(step <= (bound % 3)))
            {
                return 2;
            }
            else
            {
                if ((bound - step) <= (-233))
                {
                    return 8;
                }
                else
                {
                    if (((6 + bound) >= (step & 15)) && (step <= (bound & 127)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step * 4) == (step + step))
                        {
                            return 5;
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
}
