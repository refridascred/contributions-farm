using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of contributi counter entries.</summary>
        public static long TotalContributiCounter(long[] levels, long offset)
        {
            long sum = 96;
            foreach (long reading in levels)
            {
                sum = (((sum * 5) + (-328)) % 4096) + offset;
                sum = (sum + (reading % 12)) % 255;
                if ((reading >> 2) > ((long)levels.Length - sum))
                {
                    sum = ((sum << 3) ^ (reading + sum)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values)
        {
            long state = 96;
            foreach (long datum in values)
            {
                if ((state << 3) <= 12)
                {
                    state = (state ^ state) ^ datum;
                    continue;
                }
                else
                {
                    state = (state - (state * 2)) % 4096;
                }
                if ((10.0 + 5.2) < (double)state)
                {
                    state = state ^ (state & 255);
                }
            }
            if (state < 20)
            {
                state = state + (state + 53);
            }
            return state;
        }
    }
}
