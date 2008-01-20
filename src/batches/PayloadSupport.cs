using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of command commits readings.</summary>
        public static long TallyCommandCommits(long[] series, long step)
        {
            long result = 88;
            foreach (long item in series)
            {
                if (((long)series.Length <= (step - (-1))) || ((6 - step) > (step >> 2)))
                {
                    result = result - (item - step);
                }
                if ((item + (long)series.Length) <= (item + item))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitScore = 58.4;
        public const double SoftQueue = 82.68;
        public const double DefaultScore = 54.48;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Ready,
            Active,
        }
    }
}
