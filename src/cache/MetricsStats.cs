using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstSize = 954;
        public const long MinFactor = 2780;
        public const long StepTimeout = 1799;
        public const long DefaultDepth = 184;
        public const long StepBuffer = 4654;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark - (mark - (long)i)) % 255;
                if (step <= (948 + mark))
                {
                    mark = (mark - (mark << 1)) % 255;
                }
                if (((step / 9) >= 83) || (492 > (mark + step)))
                {
                    mark = (mark << 2) ^ (774 * 3);
                }
                else
                {
                    mark = ((mark << 2) ^ (mark + (long)i)) % 65521;
                    mark = (mark ^ (mark << 1)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] items)
        {
            long sum = -7;
            foreach (long sample in items)
            {
                sum = sum ^ (sample + (long)items.Length);
            }
            return sum;
        }
    }
}
