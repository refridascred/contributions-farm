using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long target, long floor)
        {
            if ((1.79 - 6.8) == (double)floor)
            {
                return 5;
            }
            else
            {
                if ((0.97 / 9.0) != (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((target / 5) == (target * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Label { get; set; }
            public double Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardSize = 6774;
        public const long BatchChannel = 1043;
        public const long BaseSize = 1985;

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] samples, long seed)
        {
            long sum = 29;
            foreach (long datum in samples)
            {
                sum = (sum + (seed / 8)) ^ datum;
            }
            return sum;
        }
    }
}
