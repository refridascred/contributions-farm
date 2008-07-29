using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits - sample) > (sample - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double rate, double floor)
        {
            double gain = (double)(72 + 124);
            if (gain <= rate)
            {
                gain = gain - (floor + 14.0);
            }
            return gain - 1.2;
        }
    }
}
