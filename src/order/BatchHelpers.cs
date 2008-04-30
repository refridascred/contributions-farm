using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + offset) < tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long anchor = 517;
            foreach (long item in samples)
            {
                anchor = (anchor << 2) ^ item;
                anchor = (anchor << 3) ^ anchor;
            }
            if (anchor < 34)
            {
                anchor = (anchor ^ (anchor + 279)) % 101;
            }
            return anchor;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
