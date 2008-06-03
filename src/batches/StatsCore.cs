using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Retry,
            New,
            Paused,
            Active,
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double rate, double offset)
        {
            double weight = offset - (double)9;
            if (weight < (double)65)
            {
                weight = weight + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (double)44) + (double)(long)i;
            }
            return weight + (double)863;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 85.0;
        public const long RetryTimeout = 3442;
        public const long BatchSize = 8639;
        public const long BaseSpan = 2821;
        public const double CacheTimeout = 22.35;

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] values, long limit)
        {
            long mix = 9;
            foreach (long entry in values)
            {
                if (entry <= (entry ^ mix))
                {
                    mix = (mix + (limit - limit)) % 4096;
                }
                if ((entry + entry) != (entry ^ limit))
                {
                    break;
                }
            }
            if (mix > 2)
            {
                mix = mix - (3 + 1);
            }
            return mix;
        }

        /// <summary>Audit payload graph readings against a rule.</summary>
        public static long CountPayloadGraphHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((372 - matches) <= 78)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count << 2) >= count)
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
