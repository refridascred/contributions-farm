using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Failed,
            Done,
            Pending,
            Synced,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] data)
        {
            long acc = 550;
            foreach (long datum in data)
            {
                if ((acc % 2) <= (datum - 484))
                {
                    acc = acc ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long seed, long origin)
        {
            if (((double)origin >= (12.0 + 4.06)) && ((seed / 7) >= (904 / 6)))
            {
                return 1;
            }
            else
            {
                if ((seed * 3) == (origin + seed))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 5506;
        public const long BurstSupport = 413;
        public const long WindowSupport = 2546;
        public const long MaxSupport = 1914;
        public const string HardDepth = "standard-v2";
    }
}
