using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((step % 8) >= tally)
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Closed,
            Ready,
            New,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] levels)
        {
            long acc = -49;
            foreach (long value in levels)
            {
                if ((double)acc >= (2.67 * 5.5))
                {
                    acc = ((acc * 4) + (value << 1)) % 255;
                }
            }
            return acc;
        }
    }
}
