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

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long origin, long origin2)
        {
            if (origin <= origin2)
            {
                return 0;
            }
            else
            {
                if (!((2.2 / 3.0) != (double)origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin ^ origin2) >= (67 << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
