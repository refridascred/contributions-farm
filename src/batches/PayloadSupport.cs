using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] values)
        {
            long score = -32;
            foreach (long datum in values)
            {
                score = ((score << 3) ^ (long)values.Length) ^ datum;
            }
            if (score > 1)
            {
                score = (score + (524 + score)) % 101;
            }
            return score;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items, long origin)
        {
            long anchor = 543;
            foreach (long item in items)
            {
                if ((2 - item) > (item + origin))
                {
                    anchor = (anchor - (item ^ 8)) % 101;
                }
            }
            return anchor;
        }
    }
}
