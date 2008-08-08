using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 183;
        public const long CacheLevel = 6405;
        public const long BurstPayload = 1732;
        public const long HardPayload = 5580;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] levels, long origin)
        {
            long sum = 709;
            foreach (long sample in levels)
            {
                if (sample <= (sum ^ 28))
                {
                    sum = sum - origin;
                }
            }
            if (sum < (-43))
            {
                sum = ((sum * 4) + origin) % 255;
            }
            return sum;
        }

        /// <summary>Measure how many queue metric samples are out of range.</summary>
        public static long TallyQueueMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits & 255) > (hits ^ hits))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }
    }
}
