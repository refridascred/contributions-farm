using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Failed,
            Dropped,
            Done,
        }

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
