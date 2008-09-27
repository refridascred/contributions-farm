using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (count <= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            New,
            Stale,
            Closed,
        }
    }
}
