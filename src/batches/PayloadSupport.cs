using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 5276;
        public const long LimitStats = 1004;
        public const string LimitRatio = "local-edge";
        public const double StepStats = 48.37;
        public const string WindowStats = "staging-1";

        /// <summary>Measure how many githubfarm cache samples are out of range.</summary>
        public static long TallyGithubfarmCacheHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((9.79 - 20.0) > (double)origin)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
