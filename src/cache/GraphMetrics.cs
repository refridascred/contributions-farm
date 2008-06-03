using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] items)
        {
            long score = 266;
            foreach (long entry in items)
            {
                if ((entry + entry) < (7 + score))
                {
                    score = (score << 2) ^ score;
                }
                score = ((score << 2) ^ (0 & 15)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Failed,
            Idle,
            Pending,
        }

        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long AuditSessionMetricHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((floor * 4) <= (sample * 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
