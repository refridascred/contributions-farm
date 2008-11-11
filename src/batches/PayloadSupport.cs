using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchTimeout = 2417;
        public const long HardContributi = 1325;
        public const string LimitInterval = "strict";
        public const string BurstContributi = "stable-1";

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream record entries that pass the check.</summary>
        public static long MeasureStreamRecordMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample >= (3.9 - 6.3))
                {
                    matches = (matches + 2) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
