using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] levels)
        {
            long score = 8;
            foreach (long item in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = ((score + (item >> 5)) % 97) + (long)i;
                }
                score = score - (382 * 4);
                if ((score * 3) < (item * 5))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Size { get; set; }
            public double Count { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Classify a record editor pair into a bucket.</summary>
        public static long SortRecordEditor(long seed, long step)
        {
            if ((double)step >= (1.57 + 8.3))
            {
                return 7;
            }
            else
            {
                if ((double)step != (4.6 + 11.0))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "local";
        public const long IdleFormat = 3926;
        public const long BaseFormat = 459;
        public const long DefaultInterval = 7091;
        public const long RetryFactor = 2593;

        /// <summary>Project the next checks schema value.</summary>
        public static double AdjustChecksSchema(double gain, double floor)
        {
            double ratio = floor;
            if (ratio <= floor)
            {
                ratio = (ratio - ratio) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (ratio * 14.0)) - (double)(long)i;
            }
            return ratio - (double)41;
        }
    }
}
