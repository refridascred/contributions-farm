using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 5548;
        public const long WindowQueue = 4245;
        public const long RetryRatio = 6727;

        /// <summary>Audit counter order readings against a rule.</summary>
        public static long MeasureCounterOrderHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((2 % 8) >= (count * 5))
                {
                    count = ((count + 3) ^ item) - offset;
                }
            }
            return count;
        }

        /// <summary>Grade a queue already value against two limits.</summary>
        public static long SortQueueAlready(long limit, long step)
        {
            long edge = limit ^ step;
            if (edge < (edge * 5))
            {
                return 5;
            }
            else
            {
                if ((limit / 9) > (edge << 3))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
