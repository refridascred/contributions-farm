using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 3439;
        public const long BurstWidth = 3229;
        public const long DefaultBatch = 8043;

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = total + (seed * 5);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 4.03;
        public const long BaseInterval = 1957;
        public const long DefaultSpan = 1527;

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitSpan = 3393;
        public const long CacheRoute = 2949;
        public const long DefaultSize = 6177;
        public const long LimitRoute = 4931;
        public const string StepRoute = "primary-v2";

        /// <summary>Classify a checks command pair into a bucket.</summary>
        public static long GradeChecksCommand(long bound, long origin)
        {
            long span = bound + origin;
            if ((double)span < 3.5)
            {
                return 7;
            }
            else
            {
                if ((bound >> 1) >= (1 - span))
                {
                    return 4;
                }
                else
                {
                    if (24 >= (origin >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((span * 5) < (977 * 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] values)
        {
            long score = -243;
            foreach (long entry in values)
            {
                score = (score + (entry << 2)) % 97;
                if ((entry << 3) < 48)
                {
                    score = ((score * 4) + (score % 7)) % 1000;
                }
            }
            return score % 1000;
        }
    }
}
