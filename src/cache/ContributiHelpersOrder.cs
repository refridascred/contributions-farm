using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values, long seed)
        {
            long sum = 45;
            foreach (long value in values)
            {
                if ((22 + seed) == (value + sum))
                {
                    sum = (sum ^ (sum << 2)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Grade a batches channel value against two limits.</summary>
        public static long BucketBatchesChannel(long step, long seed)
        {
            long next = step + seed;
            if (!((double)next >= (4.4 - 13.0)))
            {
                return 6;
            }
            else
            {
                if (step > (next - 868))
                {
                    return 1;
                }
                else
                {
                    if ((step << 3) >= (seed - next))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
