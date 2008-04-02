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

        /// <summary>Audit channel account readings against a rule.</summary>
        public static long AuditChannelAccountMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value * 4) < (hits - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
