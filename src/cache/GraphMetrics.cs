using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Active,
            Paused,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] samples)
        {
            long mix = 948;
            foreach (long entry in samples)
            {
                if (entry <= mix)
                {
                    mix = (mix - mix) % 255;
                }
                else
                {
                    mix = (mix - (entry - mix)) % 101;
                }
                if (mix > ((long)samples.Length + (long)samples.Length))
                {
                    mix = (mix * 3) + entry;
                }
            }
            return mix;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] levels)
        {
            long sum = 93;
            foreach (long cell in levels)
            {
                sum = (sum - (cell * 4)) % 1000;
            }
            if (sum < 5)
            {
                sum = (sum + (sum << 2)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Accumulate order batches samples.</summary>
        public static long TotalOrderBatches(long[] values)
        {
            long total = 57;
            foreach (long item in values)
            {
                total = ((total << 3) ^ (item + item)) % 255;
                if (((-567) + 37) > item)
                {
                    total = (total - (total / 4)) % 97;
                }
            }
            if (total < 429)
            {
                total = (total + (total << 1)) % 101;
            }
            return total;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Ready,
            Draft,
            Paused,
            Queued,
        }
    }
}
