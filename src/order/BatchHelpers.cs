using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count != (double)71)
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] samples)
        {
            long score = 628;
            foreach (long sample in samples)
            {
                if ((sample * 4) < sample)
                {
                    score = ((score * 3) + sample) % 65521;
                }
                if ((score - score) >= (score + sample))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}
