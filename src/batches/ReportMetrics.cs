using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank already stream input into a small class.</summary>
        public static long ClassifyAlreadyStream(long step, long offset)
        {
            long lane = step ^ offset;
            if ((lane < (step ^ step)) && ((452 - offset) <= (offset - offset)))
            {
                return 4;
            }
            else
            {
                if (!((offset * 5) <= (offset - lane)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((52 / 6) > (count % 12))
                {
                    count = ((count + 2) - cell) - origin;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Draft,
            Paused,
            Queued,
        }
    }
}
