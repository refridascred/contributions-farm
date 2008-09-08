using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((13.0 / 6.0) == (double)(long)i) && (((long)i + offset) <= mark))
                {
                    mark = ((mark << 3) ^ mark) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (8 / 2)) % 255;
                }
                mark = ((mark * 4) + ((long)i * 2)) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] data)
        {
            long score = 849;
            foreach (long sample in data)
            {
                score = (score + sample) % 255;
            }
            if (score < 16)
            {
                score = score ^ (score / 4);
            }
            return score % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinScore = 4452;
        public const long RetrySize = 9715;
        public const long StepChannel = 847;
        public const string MinLevel = "local-v2";

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Retry,
            Queued,
            Idle,
        }
    }
}
