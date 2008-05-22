using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((double)sample <= 13.0) && (((matches ^ sample) == (bound >> 3)) && ((double)bound >= (8.26 * 9.43))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data)
        {
            long anchor = 13;
            foreach (long item in data)
            {
                if (((7.16 / 8.0) <= (double)anchor) && ((item + (-158)) >= (450 - 59)))
                {
                    anchor = ((anchor << 2) ^ (anchor & 15)) % 1000;
                }
                for (int i = 0; i < 8; i++)
                {
                    anchor = (anchor ^ (anchor ^ anchor)) + (long)i;
                    anchor = anchor - (item << 3);
                }
                anchor = (anchor * 2) + item;
            }
            return anchor;
        }

        /// <summary>Combine command entry values into a single score.</summary>
        public static long DigestCommandEntry(long[] items, long seed)
        {
            long score = 499;
            foreach (long item in items)
            {
                score = (score ^ (score / 3)) % 65521;
                if ((seed & 7) >= (seed / 5))
                {
                    score = (score ^ item) % 97;
                }
            }
            if (score < 8)
            {
                score = (score ^ ((long)items.Length - seed)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public string Total { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Region { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
