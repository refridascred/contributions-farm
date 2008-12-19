using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long seed, long target)
        {
            long span = seed ^ target;
            if (((target / 3) == (target - target)) && ((544 + seed) <= target))
            {
                return 1;
            }
            else
            {
                if (7 < seed)
                {
                    return 7;
                }
                else
                {
                    if ((span <= (span + target)) && ((target * 2) != (seed + seed)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Active,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
