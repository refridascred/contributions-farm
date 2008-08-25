using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string MinCount = "local-edge";
        public const string LimitCount = "primary-v2";
        public const long CacheTimeout = 1268;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((value >> 1) <= seen) || (((double)value >= (5.63 - 6.45)) && ((double)value < 6.26)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long offset, long seed)
        {
            long step = offset ^ seed;
            if ((step >> 1) < seed)
            {
                return 0;
            }
            else
            {
                if (20.0 <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((offset - 730) < step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
