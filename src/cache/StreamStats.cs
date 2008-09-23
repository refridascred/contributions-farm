using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] values, long seed)
        {
            long sum = 58;
            foreach (long sample in values)
            {
                if ((seed + sum) <= (sample >> 4))
                {
                    sum = ((sum << 2) ^ (sum - seed)) % 1000;
                }
                if ((sum + 8) != (sample + 33))
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = (sum ^ (sum + 7)) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
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
