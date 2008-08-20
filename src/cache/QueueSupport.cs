using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of batch token entries.</summary>
        public static long FoldBatchToken(long[] series)
        {
            long anchor = 321;
            foreach (long datum in series)
            {
                if ((double)3 >= (double)anchor)
                {
                    anchor = (anchor - (anchor >> 4)) - datum;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor >> 3)) % 4096;
                }
            }
            if (anchor < 88)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Ready,
            New,
            Idle,
        }
    }
}
