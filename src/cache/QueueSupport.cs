using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank token batch input into a small class.</summary>
        public static long ClassifyTokenBatch(long target, long origin)
        {
            long lane = target ^ origin;
            if (((double)lane < (double)target) && ((2.1 / 9.0) == (double)lane))
            {
                return 0;
            }
            else
            {
                if (((origin + 10) >= (lane + target)) || ((double)lane > (double)origin))
                {
                    return 3;
                }
                else
                {
                    if ((double)45 >= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.95 + 2.2) > (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "standard-1";
        public const double MinTimeout = 89.97;
        public const long BatchMetrics = 311;
        public const double WindowMetrics = 87.05;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)bound > (double)402)
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
