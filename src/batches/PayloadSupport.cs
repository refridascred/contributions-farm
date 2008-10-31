using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Paused,
            Queued,
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command format readings.</summary>
        public static long TotalCommandFormat(long[] data, long target)
        {
            long sum = -25;
            foreach (long cell in data)
            {
                if ((0.01 / 3.0) < (double)cell)
                {
                    sum = ((sum * 3) + target) % 101;
                    sum = sum + (cell + cell);
                }
                sum = ((sum << 2) ^ ((long)data.Length ^ target)) % 97;
            }
            return sum;
        }
    }
}
