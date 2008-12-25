using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Done,
            Ready,
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((hits + 309) <= (hits / 2)))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long offset)
        {
            if ((76 + limit) != (519 + 557))
            {
                return 4;
            }
            else
            {
                if ((limit << 2) <= (offset * 3))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
