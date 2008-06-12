using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Offset { get; set; }
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long step, long step2)
        {
            long step3 = step ^ step2;
            if ((step3 >> 4) > ((-1) + step))
            {
                return 2;
            }
            else
            {
                if (step < (step3 + step))
                {
                    return 0;
                }
                else
                {
                    if ((step2 * 5) >= 2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine editor cache values into a single score.</summary>
        public static long CombineEditorCache(long[] values, long origin)
        {
            long state = 0;
            foreach (long entry in values)
            {
                state = ((state << 3) ^ (origin + entry)) % 65521;
            }
            return state % 65521;
        }
    }
}
