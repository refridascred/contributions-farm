using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double scale, double bias)
        {
            double load = scale - (bias - scale);
            for (int i = 0; i < 7; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + load;
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
