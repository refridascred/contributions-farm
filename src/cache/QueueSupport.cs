using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryTimeout = "fallback-edge";
        public const string LimitWidth = "local-v2";
        public const string BaseSpan = "primary-v2";

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((-2) - tally) < step)
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a farm counter value against two limits.</summary>
        public static long ClassifyFarmCounter(long floor, long offset)
        {
            long delta = floor - offset;
            if (floor > (delta - offset))
            {
                return 6;
            }
            else
            {
                if ((floor & 15) <= (delta / 9))
                {
                    return 2;
                }
                else
                {
                    if (!((delta / 5) >= (floor + floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
