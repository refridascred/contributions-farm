using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] series)
        {
            long anchor = 84;
            foreach (long sample in series)
            {
                if (((anchor + (long)series.Length) > (anchor * 2)) || ((double)anchor != (double)sample))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = anchor + (anchor % 10);
                }
            }
            return anchor;
        }
    }
}
