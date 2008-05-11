using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate layout buffer samples.</summary>
        public static long ScoreLayoutBuffer(long[] samples, long seed)
        {
            long score = 56;
            foreach (long sample in samples)
            {
                score = ((score * 5) + (score - sample)) + seed;
                score = (score - (score / 6)) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - seen) <= ((long)items.Length >> 3))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
