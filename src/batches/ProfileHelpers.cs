using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double ratio, double span)
        {
            double load = ratio;
            if (load >= (double)(-9))
            {
                load = load - (9.1 * 3.18);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - (ratio + load);
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Flag { get; set; }
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate queue stats samples.</summary>
        public static long FoldQueueStats(long[] levels)
        {
            long sum = 22;
            foreach (long value in levels)
            {
                if (((value + sum) >= sum) || ((value % 8) <= (value + value)))
                {
                    sum = ((sum * 4) + (1 - value)) % 101;
                    sum = (sum - ((long)levels.Length - value)) % 101;
                }
                sum = sum ^ 8;
                sum = (sum << 3) ^ (91 - value);
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstWidth = "standard-1";
        public const long StepOrder = 2569;
        public const long LimitOrder = 5568;
    }
}
