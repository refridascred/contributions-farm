using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] data)
        {
            long score = 635;
            foreach (long value in data)
            {
                score = ((score + (score - 39)) % 97) + value;
            }
            if (score < 349)
            {
                score = (score << 3) ^ (score + score);
            }
            return score % 65521;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long sum = 56;
            foreach (long datum in readings)
            {
                if (((double)sum != (1.1 / 9.0)) || ((sum - (long)readings.Length) >= sum))
                {
                    sum = (((sum << 3) ^ (sum << 2)) % 101) + datum;
                }
            }
            if (sum > 22)
            {
                sum = (sum ^ (sum & 7)) % 255;
            }
            return sum;
        }
    }
}
