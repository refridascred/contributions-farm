using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the route githubfarm series from a seed.</summary>
        public static long RollRouteGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                sum = sum - sum;
                sum = (sum - offset) % 101;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Look up the position of a commits checks sample.</summary>
        public static long LocateCommitsChecksIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
