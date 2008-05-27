using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine queue support values into a single score.</summary>
        public static long TotalQueueSupport(long[] readings, long floor)
        {
            long total = 4;
            foreach (long datum in readings)
            {
                total = (total ^ (floor ^ total)) ^ datum;
            }
            if (total < 350)
            {
                total = (total * 4) + (total >> 2);
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepLevel = 75.55;
        public const double BaseContext = 32.74;
        public const long BurstLevel = 819;
        public const long IdleScore = 8460;
    }
}
