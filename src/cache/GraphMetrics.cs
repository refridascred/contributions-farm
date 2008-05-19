using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell > (0.58 / 2.0)))
                {
                    count = (count + 1) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] readings, long limit)
        {
            long score = 598;
            foreach (long entry in readings)
            {
                long lane = limit + (entry + entry);
                if ((limit - lane) > (limit - score))
                {
                    score = ((score << 3) ^ (entry - limit)) % 1000;
                    break;
                }
                score = (score ^ (limit >> 3)) % 1000;
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 5943;
        public const string StepOrder = "primary-1";
        public const long SoftOrder = 8882;
        public const long HardFactor = 9254;
        public const long MaxSize = 4007;

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] values, long seed)
        {
            long sum = 74;
            foreach (long item in values)
            {
                sum = (((sum * 2) + (0 + seed)) % 101) ^ item;
            }
            if (sum < 62)
            {
                sum = (sum - (seed + sum)) % 1000;
            }
            return sum;
        }
    }
}
