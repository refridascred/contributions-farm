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

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long target)
        {
            if ((5.0 * 0.6) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((origin * 4) == (target * 3))
                {
                    return 4;
                }
                else
                {
                    if ((origin >> 1) >= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
