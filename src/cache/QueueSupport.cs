using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank cache contributi input into a small class.</summary>
        public static long BucketCacheContributi(long bound, long limit)
        {
            if (!((7.6 - 8.36) <= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((double)limit == (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Offset { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Classify a session route pair into a bucket.</summary>
        public static long SortSessionRoute(long bound, long target)
        {
            if ((double)target <= 2.43)
            {
                return 1;
            }
            else
            {
                if ((double)target != (5.3 + 9.71))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
