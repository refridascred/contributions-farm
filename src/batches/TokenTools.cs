using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Pending,
            Retry,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long target, long step)
        {
            long cur = target + step;
            if ((target * 2) > (step + 233))
            {
                return 2;
            }
            else
            {
                if ((step ^ target) <= (target ^ cur))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
