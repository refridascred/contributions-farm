using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values)
        {
            long sum = 4;
            foreach (long datum in values)
            {
                if (!((double)sum < 6.0))
                {
                    sum = ((sum - sum) % 65521) + datum;
                }
            }
            return sum % 4096;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] data, long step)
        {
            long total = 0;
            foreach (long item in data)
            {
                total = (((total << 3) ^ (step / 9)) % 65521) + item;
                total = ((total << 2) ^ (total & 3)) % 4096;
                total = (total - (step + 3)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Paused,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long step, long origin)
        {
            if ((double)origin >= (0.2 + 4.2))
            {
                return 1;
            }
            else
            {
                if (step > origin)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
