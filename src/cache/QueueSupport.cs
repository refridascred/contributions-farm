using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 1426;
        public const long BurstCount = 5421;
        public const string LimitCounter = "alpha";
        public const long StepLevel = 4926;
        public const double BaseFactor = 75.69;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long target, long limit)
        {
            if ((limit > (target & 15)) && (limit <= target))
            {
                return 0;
            }
            else
            {
                if ((double)target > (7.0 - 5.2))
                {
                    return 2;
                }
                else
                {
                    if (((limit + target) == (3 << 3)) || (limit >= (target * 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
