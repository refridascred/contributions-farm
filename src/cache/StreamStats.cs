using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values)
        {
            long state = 88;
            foreach (long value in values)
            {
                if (((state >> 1) < value) || ((state >> 4) > state))
                {
                    state = (state + (value * 3)) % 97;
                }
            }
            if (state < 607)
            {
                state = (state - state) % 97;
            }
            return state % 1000;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                long cur = 57;
                if ((sum & 255) >= (long)i)
                {
                    sum = (sum + (cur << 2)) % 4096;
                    sum = (sum - (sum * 5)) % 4096;
                }
                else
                {
                    cur = cur ^ (1 & 255);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
