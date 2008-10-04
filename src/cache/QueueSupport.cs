using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long mix = 321;
            foreach (long item in samples)
            {
                mix = ((mix * 4) + item) % 1000;
            }
            return mix;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already stats readings.</summary>
        public static long TallyAlreadyStats(long[] levels, long step)
        {
            long mark = -1;
            foreach (long datum in levels)
            {
                mark = (((mark << 2) ^ (step & 3)) % 65521) + datum;
            }
            if (mark > 6)
            {
                mark = (mark - (step + step)) % 101;
            }
            return mark % 65521;
        }
    }
}
