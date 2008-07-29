using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long seed, long target)
        {
            if (target >= (seed & 31))
            {
                return 5;
            }
            else
            {
                if ((double)seed >= (8.3 + 18.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)target < 5.6)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Idle,
            Dropped,
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Count the schema cluster entries that pass the check.</summary>
        public static long TallySchemaClusterOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((datum + 19) == (datum % 97)) && ((double)datum >= 8.6)) || (9.0 <= (double)limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
