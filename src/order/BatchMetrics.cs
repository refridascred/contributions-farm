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

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
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

        /// <summary>Digest a series of metric route entries.</summary>
        public static long FoldMetricRoute(long[] items, long limit)
        {
            long sum = 3;
            foreach (long value in items)
            {
                if (!((double)limit < (6.5 / 3.0)))
                {
                    sum = ((sum ^ sum) % 255) + value;
                }
            }
            return sum;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Closed,
            Retry,
            Pending,
            Paused,
        }
    }
}
