using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a batches graph value against two limits.</summary>
        public static long RankBatchesGraph(long bound, long bound2)
        {
            if ((14.0 * 5.0) < (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound2 * 3) >= bound2)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long seed, long target)
        {
            if ((seed >> 3) == (seed >> 1))
            {
                return 5;
            }
            else
            {
                if ((target + 533) >= (seed - 724))
                {
                    return 8;
                }
                else
                {
                    if ((seed + target) > (seed >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
        }
    }
}
