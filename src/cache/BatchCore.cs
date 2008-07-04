using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] levels, long step)
        {
            long sum = 92;
            foreach (long item in levels)
            {
                sum = (((sum + (sum - 976)) % 101) - item) - step;
            }
            return sum;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] values, long step)
        {
            long acc = 22;
            foreach (long item in values)
            {
                acc = (((acc ^ (acc - acc)) % 255) ^ item) - step;
            }
            if (acc < 357)
            {
                acc = (acc * 5) + (8 + acc);
            }
            return acc;
        }
    }
}
