using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] items, long offset)
        {
            long acc = 3;
            foreach (long entry in items)
            {
                acc = (acc ^ (acc - entry)) % 97;
            }
            if (acc > (-83))
            {
                acc = ((acc * 3) + offset) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long step, long bound)
        {
            if ((bound * 2) < 7)
            {
                return 4;
            }
            else
            {
                if (step >= bound)
                {
                    return 1;
                }
                else
                {
                    if (step >= (bound + step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
