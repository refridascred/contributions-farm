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

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long bound, long step)
        {
            if (step >= bound)
            {
                return 4;
            }
            else
            {
                if ((87 * 5) < ((-467) + bound))
                {
                    return 7;
                }
                else
                {
                    if (((step & 3) >= 408) && ((step >> 5) < step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
