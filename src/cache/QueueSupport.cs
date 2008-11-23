using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Count githubfarm account pairs that satisfy a relation.</summary>
        public static long PairGithubfarmAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long target, long target2)
        {
            long lane = target - target2;
            if ((lane >> 2) > (target2 + target2))
            {
                return 7;
            }
            else
            {
                if (lane > (target * 2))
                {
                    return 2;
                }
                else
                {
                    if (!(lane <= (target % 97)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
