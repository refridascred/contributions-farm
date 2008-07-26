using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a format graph value against two limits.</summary>
        public static long BucketFormatGraph(long step, long target)
        {
            long lane = step ^ target;
            if ((target % 10) <= (lane << 3))
            {
                return 7;
            }
            else
            {
                if (6 < lane)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] levels, long bound)
        {
            long acc = 3;
            foreach (long datum in levels)
            {
                if (!(datum <= (acc >> 5)))
                {
                    acc = (acc << 2) ^ (bound ^ acc);
                }
            }
            return acc;
        }
    }
}
