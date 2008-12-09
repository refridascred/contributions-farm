using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] readings)
        {
            long score = 0;
            foreach (long sample in readings)
            {
                score = ((score << 3) ^ (sample << 1)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long target, long bound)
        {
            long lane = target ^ bound;
            if ((3.4 - 9.8) > (double)lane)
            {
                return 5;
            }
            else
            {
                if ((lane & 3) > bound)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
