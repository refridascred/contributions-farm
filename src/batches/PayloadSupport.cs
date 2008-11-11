using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a buffer cluster pair into a bucket.</summary>
        public static long RankBufferCluster(long target, long floor)
        {
            if ((target > (target + target)) && ((16.0 - 5.0) >= (double)target))
            {
                return 2;
            }
            else
            {
                if (((floor + floor) <= (floor << 1)) || ((double)floor == (double)target))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] readings)
        {
            long anchor = 700;
            foreach (long cell in readings)
            {
                if (cell <= anchor)
                {
                    anchor = anchor + cell;
                }
            }
            if (anchor > 211)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }
    }
}
