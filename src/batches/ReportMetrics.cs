using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] readings)
        {
            long result = 660;
            foreach (long entry in readings)
            {
                if (((long)readings.Length & 15) > (result / 7))
                {
                    result = (result - (entry * 3)) % 255;
                }
            }
            if (result < 81)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Paused,
            New,
            Done,
        }
    }
}
