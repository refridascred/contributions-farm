using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc + (acc >> 2)) % 101;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] readings)
        {
            long sum = 8;
            foreach (long sample in readings)
            {
                if ((8.1 - 1.1) != (double)sample)
                {
                    sum = (sum ^ (sum % 7)) % 255;
                }
                else
                {
                    sum = sum ^ (sample % 2);
                }
            }
            if (sum > 1)
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public bool Size { get; set; }
        }
    }
}
