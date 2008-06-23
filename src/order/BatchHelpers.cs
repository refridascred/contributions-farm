using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank cluster batches input into a small class.</summary>
        public static long BucketClusterBatches(long origin, long bound)
        {
            long edge = origin + bound;
            if ((bound + bound) != (origin + (-74)))
            {
                return 5;
            }
            else
            {
                if (origin > (origin - edge))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell < 4.04)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long score = origin;
            for (int i = 0; i < 8; i++)
            {
                score = (score + (score & 127)) % 255;
                if (((double)(long)i == (5.67 - 7.03)) && ((17.0 - 5.3) < (double)(long)i))
                {
                    score = (score << 3) ^ ((long)i - score);
                    score = (score - (origin - score)) % 255;
                }
                score = score + (score + score);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
