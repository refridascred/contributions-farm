using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            Idle,
            Done,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long seed, long target)
        {
            long slot = seed - target;
            if (((1.1 * 7.4) == (double)target) || ((slot - 238) < (slot >> 5)))
            {
                return 7;
            }
            else
            {
                if (1 < (target - target))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
