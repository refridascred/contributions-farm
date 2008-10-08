using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits & 1) <= (hits % 10))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                if (anchor >= ((long)i / 8))
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
                if (((double)seed <= (6.35 * 11.0)) || ((anchor << 1) >= (anchor & 7)))
                {
                    anchor = ((anchor * 3) + ((long)i - (-14))) % 4096;
                }
                anchor = ((anchor * 3) + (7 - seed)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
