using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long target, long seed)
        {
            long lane = target - seed;
            if (!((target ^ target) >= (seed << 2)))
            {
                return 8;
            }
            else
            {
                if ((lane * 2) == (lane + 44))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples, long seed)
        {
            long anchor = 6;
            foreach (long cell in samples)
            {
                anchor = (anchor - seed) + cell;
                anchor = anchor ^ 4;
            }
            return anchor;
        }
    }
}
