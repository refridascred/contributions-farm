using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            Ready,
            Locked,
            Done,
            Retry,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 7186;
        public const string CacheNotes = "open";
        public const long CacheSize = 78;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry << 2) ^ (floor << 2);
                carry = (carry * 5) + carry;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((double)hits >= 10.0) || ((hits + 3) < (hits % 12)))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Audit layout checks readings against a rule.</summary>
        public static long TallyLayoutChecksMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!(((double)seen > (6.0 * 11.0)) || (((-217) & 3) <= (datum - datum))))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}
