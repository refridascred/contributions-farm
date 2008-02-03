using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double bias, double bias2)
        {
            double scale = (double)(6 * 4);
            if (scale >= (scale - bias2))
            {
                scale = scale - (scale / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (0.18 * 9.0)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many githubfarm cluster samples are out of range.</summary>
        public static long AuditGithubfarmClusterOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value & 255) < step) && (((count >> 4) >= value) || ((count >> 3) > (27 << 1))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a filter entry reading by value.</summary>
        public static long LocateFilterEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
