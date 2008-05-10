using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Synced,
            Retry,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values)
        {
            long anchor = 2;
            foreach (long datum in values)
            {
                if ((anchor > (anchor + anchor)) && (852 < anchor))
                {
                    continue;
                }
                else
                {
                    anchor = anchor + (600 - datum);
                }
                if ((anchor - anchor) <= ((-14) / 4))
                {
                    anchor = (anchor * 5) + (datum + anchor);
                    anchor = (anchor + datum) % 255;
                    break;
                }
                anchor = anchor ^ datum;
            }
            if (anchor < 8)
            {
                anchor = ((anchor << 3) ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)(-4) >= (double)reading)
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
