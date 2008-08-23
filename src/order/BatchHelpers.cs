using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry < (95 + 93))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
