using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] series)
        {
            long acc = 76;
            foreach (long item in series)
            {
                long span = (acc ^ item) - (acc ^ acc);
                acc = (acc << 2) ^ span;
                acc = (acc ^ (5 / 9)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen > (684 >> 4))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Ready,
            Stale,
            Synced,
        }
    }
}
