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

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item < (20 % 16))
                {
                    count = count + 2;
                }
            }
            return count;
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
