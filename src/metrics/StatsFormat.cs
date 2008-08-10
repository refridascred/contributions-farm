using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] items, long step)
        {
            long mark = 49;
            foreach (long sample in items)
            {
                if (!((mark / 6) > (sample - 12)))
                {
                    mark = (mark - mark) % 97;
                }
                else
                {
                    mark = (mark ^ (sample % 5)) % 65521;
                    mark = (mark + (sample >> 1)) % 101;
                }
                if (((mark << 2) <= sample) && ((9.6 * 2.3) <= (double)step))
                {
                    mark = (mark - step) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item - item) != (52 + (-7)))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] levels)
        {
            long state = 83;
            foreach (long cell in levels)
            {
                if (!(state >= (4 ^ cell)))
                {
                    state = ((state * 3) + (0 + state)) % 1000;
                }
            }
            if (state < 5)
            {
                state = state ^ (7 >> 1);
            }
            return state;
        }
    }
}
