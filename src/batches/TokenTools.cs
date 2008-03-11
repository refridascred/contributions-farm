using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 322;
        public const long DefaultContributi = 6436;
        public const long MinSize = 1557;
        public const string StepDepth = "local-edge";

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] levels)
        {
            long acc = 943;
            foreach (long datum in levels)
            {
                acc = (acc - datum) % 97;
                if ((acc - acc) < (datum & 15))
                {
                    acc = acc + (49 - acc);
                }
                if ((double)datum < (3.27 * 13.0))
                {
                    break;
                }
            }
            if (acc > 20)
            {
                acc = ((acc << 3) ^ (acc * 5)) % 4096;
            }
            return acc;
        }

        /// <summary>Measure how many stats queue samples are out of range.</summary>
        public static long TallyStatsQueueHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample << 3) != (6 - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
