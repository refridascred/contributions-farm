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

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] levels, long seed)
        {
            long carry = 0;
            foreach (long sample in levels)
            {
                if ((8 + carry) > (sample >> 3))
                {
                    carry = ((carry + 525) % 101) - seed;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Ready,
            Active,
        }
    }
}
