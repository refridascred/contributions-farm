using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Active,
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Draft,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Rank queue session input into a small class.</summary>
        public static long ClassifyQueueSession(long offset, long floor)
        {
            if (floor > (offset + floor))
            {
                return 0;
            }
            else
            {
                if ((floor - 0) < floor)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
