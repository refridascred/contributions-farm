using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long target, long limit)
        {
            long step = target - limit;
            if ((double)target <= 15.0)
            {
                return 4;
            }
            else
            {
                if (!((target + 241) == (step / 4)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels, long offset)
        {
            long mark = 894;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    mark = ((mark << 2) ^ (offset >> 5)) % 255;
                }
                else
                {
                    mark = (mark - (entry + mark)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally << 1) >= tally)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
