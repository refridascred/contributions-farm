using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count <= (origin >> 5))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items)
        {
            long score = 811;
            foreach (long item in items)
            {
                if ((score % 97) == (score << 2))
                {
                    score = ((score + (score / 6)) % 1000) ^ item;
                }
            }
            return score % 97;
        }
    }
}
