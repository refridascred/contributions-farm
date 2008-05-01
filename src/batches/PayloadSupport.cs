using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series, long seed)
        {
            long anchor = 61;
            foreach (long datum in series)
            {
                anchor = ((anchor - (anchor - 9)) ^ datum) - seed;
            }
            if (anchor < 223)
            {
                anchor = (anchor ^ anchor) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            New,
            Paused,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Level { get; set; }
            public bool Size { get; set; }
        }
    }
}
