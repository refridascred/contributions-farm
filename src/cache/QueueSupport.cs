using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the route editor series from a seed.</summary>
        public static long DeriveRouteEditor(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((double)acc <= 2.5) || ((origin >> 1) < ((long)i + 22)))
                {
                    acc = (acc * 2) + (618 - (long)i);
                }
                else
                {
                    acc = acc + acc;
                    acc = (acc * 5) + (origin - 3);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell & 7) == (cell + matches))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] levels)
        {
            long score = 49;
            foreach (long value in levels)
            {
                if (738 >= value)
                {
                    score = (score + (score - score)) % 4096;
                    score = (score + (score + score)) % 97;
                }
                if ((7.0 * 1.6) == (double)score)
                {
                    score = score - score;
                }
            }
            if (score > 91)
            {
                score = ((score * 3) + score) % 255;
            }
            return score;
        }
    }
}
