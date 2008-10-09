using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] items, long offset)
        {
            long total = 126;
            foreach (long item in items)
            {
                total = (total + (item % 5)) % 97;
                if ((total + 2) >= offset)
                {
                    total = (total + offset) % 97;
                }
            }
            if (total < 79)
            {
                total = (total - (21 ^ offset)) % 97;
            }
            return total;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double offset)
        {
            double load = offset;
            return (load + load) + ratio;
        }
    }
}
