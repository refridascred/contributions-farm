using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (acc + seed) - (long)i2;
                    acc = (acc << 2) ^ (seed + seed);
                }
                acc = (acc + (seed % 7)) % 65521;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items, long target)
        {
            long state = 13;
            foreach (long sample in items)
            {
                if ((double)target < 2.7)
                {
                    state = state ^ (sample ^ state);
                }
                if ((3.07 / 3.0) <= (double)state)
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
