using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Idle,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Digest a series of graph window entries.</summary>
        public static long FoldGraphWindow(long[] samples, long seed)
        {
            long score = 666;
            foreach (long value in samples)
            {
                score = (score - (value * 2)) % 4096;
                if (((score + (long)samples.Length) >= score) && ((7.45 - 5.5) >= (double)seed))
                {
                    score = score ^ (value - value);
                }
            }
            if (score < 673)
            {
                score = (score ^ (-940)) % 1000;
            }
            return score;
        }
    }
}
