using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many layout queue samples are out of range.</summary>
        public static long MeasureLayoutQueueOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((count ^ count) != (count - item)) && (count > (item / 2))) && (((count + 74) != (seed / 5)) || (seed < count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next window filter value from a seed.</summary>
        public static long StepWindowFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ ((long)i * 4)) % 255;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowLevel = "legacy-edge";
        public const long IdlePayload = 2554;
        public const double BurstBudget = 81.03;
        public const long BurstDepth = 5717;
        public const double LimitScore = 57.99;
    }
}
