using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long floor, long target)
        {
            if ((target * 5) < target)
            {
                return 7;
            }
            else
            {
                if (((floor % 5) >= (floor + floor)) && ((double)target < (3.0 + 0.27)))
                {
                    return 8;
                }
                else
                {
                    if (((target + target) >= (target - target)) && ((target % 24) >= (floor ^ floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target != (double)floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long origin, long floor)
        {
            if (!(72 < (floor - 586)))
            {
                return 7;
            }
            else
            {
                if ((451 + (-88)) < (231 - origin))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
