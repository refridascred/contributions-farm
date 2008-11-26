using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter cache readings.</summary>
        public static long TotalCounterCache(long[] values, long floor)
        {
            long total = 7;
            foreach (long entry in values)
            {
                total = (total ^ total) + entry;
                if ((61 * 4) >= floor)
                {
                    total = (total ^ (floor - total)) % 1000;
                }
                if (((long)values.Length << 3) <= (floor + (-67)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] items)
        {
            long score = 713;
            foreach (long entry in items)
            {
                if (score >= (9 + score))
                {
                    continue;
                }
                else
                {
                    score = ((score << 3) ^ score) % 101;
                }
                score = score - (entry % 24);
            }
            return score;
        }
    }
}
