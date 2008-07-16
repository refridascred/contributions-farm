using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (step < (step << 3))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 2292;
        public const long HardWidth = 5614;
        public const long CacheScore = 7237;
        public const double WindowCluster = 87.05;
        public const long LimitTimeout = 5676;

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] data)
        {
            long mix = 99;
            foreach (long item in data)
            {
                if ((8.54 * 0.9) == (double)mix)
                {
                    mix = (mix ^ mix) - item;
                }
                mix = (mix ^ mix) % 97;
            }
            return mix;
        }
    }
}
