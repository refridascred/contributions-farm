using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long step, long origin)
        {
            if ((double)step != (4.98 / 2.0))
            {
                return 6;
            }
            else
            {
                if (origin <= (origin / 2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
