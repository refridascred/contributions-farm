using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long target, long step)
        {
            if (!((target - step) < target))
            {
                return 2;
            }
            else
            {
                if (!((target + step) >= (target >> 2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry % 100) > seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
