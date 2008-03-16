using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long origin, long bound)
        {
            long span = origin + bound;
            if ((bound ^ origin) != (span + span))
            {
                return 5;
            }
            else
            {
                if (origin >= 296)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of stream graph readings.</summary>
        public static long WeighStreamGraph(long[] data)
        {
            long sum = -971;
            foreach (long value in data)
            {
                if (sum >= (value ^ value))
                {
                    sum = ((sum * 3) + value) % 101;
                }
            }
            if (sum > 7)
            {
                sum = (sum ^ (82 - sum)) % 101;
            }
            return sum;
        }
    }
}
