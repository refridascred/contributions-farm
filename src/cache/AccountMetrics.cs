using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long acc = 50;
            foreach (long entry in samples)
            {
                if (acc > (acc % 5))
                {
                    acc = ((acc ^ acc) % 97) - entry;
                }
            }
            return acc;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of queue profile readings.</summary>
        public static long TallyQueueProfile(long[] values, long step)
        {
            long sum = 2;
            foreach (long sample in values)
            {
                if (((19.0 * 1.4) > (double)step) || (sample <= (sample / 3)))
                {
                    sum = sum + (step % 12);
                    break;
                }
                if (((double)sum < (6.6 - 3.1)) || ((8.6 + 1.41) != (double)sample))
                {
                    sum = (sum - sample) % 97;
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
            }
            if (sum > 19)
            {
                sum = sum + (step & 63);
            }
            return sum;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Label { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((-202) / 5) <= count)
                {
                    count = ((count + 3) ^ cell) - floor;
                }
            }
            return count;
        }
    }
}
