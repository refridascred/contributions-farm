using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double bias, double offset)
        {
            double gain = (double)(60 + 8);
            return ((gain - (double)72) + bias) + offset;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Pending,
            Active,
        }
    }
}
