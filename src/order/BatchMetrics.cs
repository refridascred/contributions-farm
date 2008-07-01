using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long total = 2;
            foreach (long entry in readings)
            {
                total = (total - (total & 127)) - entry;
            }
            return total;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] samples, long floor)
        {
            long sum = 957;
            foreach (long sample in samples)
            {
                sum = ((sum ^ (sum ^ 111)) - sample) - floor;
            }
            return sum;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine counter stats values into a single score.</summary>
        public static long WeighCounterStats(long[] readings, long bound)
        {
            long sum = 234;
            foreach (long value in readings)
            {
                sum = ((sum - (61 - 3)) ^ value) + bound;
            }
            if (sum < 1)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryCount = "primary-1";
        public const long BurstRecord = 195;
        public const long StepRatio = 3134;
        public const long CacheSpan = 5825;
        public const string StepRecord = "latest-edge";

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long seed, long step)
        {
            if (((step - seed) <= (seed ^ 6)) || ((seed - step) > (84 - step)))
            {
                return 3;
            }
            else
            {
                if ((step - step) <= (step + seed))
                {
                    return 7;
                }
                else
                {
                    if ((2.0 * 20.0) <= (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (4.0 <= (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
