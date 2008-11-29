using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 6268;
        public const long StepBatch = 9926;
        public const double BaseFactor = 83.59;
        public const long BaseBatch = 8157;
        public const long IdleLevel = 124;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Paused,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxLevel = 32.75;
        public const double MaxAccount = 85.14;
        public const long IdleAccount = 4625;
        public const long MaxCount = 3094;
        public const long SoftAccount = 424;

        /// <summary>Classify a commits stats pair into a bucket.</summary>
        public static long RankCommitsStats(long seed, long bound)
        {
            long diff = seed ^ bound;
            if (((diff - bound) > (763 / 3)) || (6 <= (diff << 2)))
            {
                return 8;
            }
            else
            {
                if ((diff & 255) < (bound - seed))
                {
                    return 0;
                }
                else
                {
                    if (!(diff > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7 << 2) > (bound + diff))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double bias, double floor)
        {
            double scale = 1.4;
            for (int i = 0; i < 3; i++)
            {
                scale = (((scale - (scale / 5.0)) + (double)(long)i) + bias) - floor;
            }
            return scale + (double)(-552);
        }

        /// <summary>Measure how many batches window samples are out of range.</summary>
        public static long CountBatchesWindowGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (bound > (cell >> 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
