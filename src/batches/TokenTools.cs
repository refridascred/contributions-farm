using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a layout payload pair into a bucket.</summary>
        public static long BucketLayoutPayload(long step, long seed)
        {
            if ((60 + step) >= (step * 2))
            {
                return 1;
            }
            else
            {
                if (!((5.3 - 2.5) < (double)seed))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a route layout reading by value.</summary>
        public static long FindRouteLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Retry,
            Pending,
            Done,
            New,
        }
    }
}
