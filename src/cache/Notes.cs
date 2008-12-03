using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((step << 1) > (entry % 64))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Classify a already filter pair into a bucket.</summary>
        public static long RankAlreadyFilter(long target, long target2)
        {
            long slot = target + target2;
            if ((target - target) > target2)
            {
                return 6;
            }
            else
            {
                if ((16.0 > (double)slot) || ((slot + target2) < (target2 + 2)))
                {
                    return 5;
                }
                else
                {
                    if ((9.1 + 2.09) < (double)slot)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            Pending,
            New,
            Queued,
            Done,
        }
    }
}
