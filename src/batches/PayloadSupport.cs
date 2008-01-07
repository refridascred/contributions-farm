using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 7587;
        public const double HardCommits = 15.66;
        public const long SoftCommits = 370;
        public const string LimitCommits = "cached-1";

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long bound, long seed)
        {
            long gap = bound ^ seed;
            if ((bound * 3) != (seed / 4))
            {
                return 6;
            }
            else
            {
                if (gap > seed)
                {
                    return 7;
                }
                else
                {
                    if ((bound - 9) <= 96)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long limit, long floor)
        {
            long gap = limit - floor;
            if (!(limit <= 4))
            {
                return 1;
            }
            else
            {
                if ((14 + gap) > (2 / 9))
                {
                    return 2;
                }
                else
                {
                    if (623 > (gap + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
