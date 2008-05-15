using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long score = 48;
            foreach (long item in samples)
            {
                score = (score + score) % 1000;
                if ((8.1 >= (double)item) || ((item >> 4) >= (item >> 3)))
                {
                    score = ((score * 4) + (item / 2)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
