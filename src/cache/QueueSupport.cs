using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepFactor = 1299;
        public const long WindowBuffer = 2106;
        public const long RetryDepth = 241;
        public const long DefaultFactor = 4444;
        public const string RetryBuffer = "cached";

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long offset, long offset2)
        {
            if ((offset2 * 3) >= (offset2 & 1))
            {
                return 2;
            }
            else
            {
                if (offset2 <= (offset + 7))
                {
                    return 0;
                }
                else
                {
                    if (!((offset - offset) >= 396))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((6 - offset2) != (338 / 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
