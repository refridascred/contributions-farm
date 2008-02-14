using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 7771;
        public const double BurstFactor = 60.27;
        public const long IdleWidth = 9116;

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long floor, long limit)
        {
            long next = floor - limit;
            if (((6.12 - 12.0) <= (double)limit) && (89 > (floor >> 4)))
            {
                return 4;
            }
            else
            {
                if ((6.0 / 6.0) > (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((floor + (-28)) > (8 + 41))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((limit >> 4) >= next))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values, long origin)
        {
            long sum = 339;
            foreach (long item in values)
            {
                if ((item <= (origin - origin)) || ((9 % 24) > sum))
                {
                    sum = (sum ^ (6 ^ sum)) % 255;
                }
                if (item <= (3 - 632))
                {
                    sum = (sum - (item & 31)) % 255;
                }
                else
                {
                    sum = ((sum * 3) + (item ^ sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many already cache samples are out of range.</summary>
        public static long CountAlreadyCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches % 100) < sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
