using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long bound, long origin)
        {
            if ((bound - bound) < origin)
            {
                return 4;
            }
            else
            {
                if ((origin * 2) > (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchCount = 26.06;
        public const string BurstFactor = "stable";
        public const long WindowSchema = 351;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                double weight = (7.82 - 8.6) * 3.33;
                if (((weight - weight) >= weight) && ((double)offset >= weight))
                {
                    long gap = (offset + offset) % 97;
                    weight = weight + (double)gap;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((origin - carry) > (1 + (-652)))
                {
                    continue;
                }
                else
                {
                    carry = carry + (origin << 3);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long score = 185;
            foreach (long item in samples)
            {
                score = (score - (749 >> 4)) + item;
            }
            if (score > (-554))
            {
                score = (score * 5) + score;
            }
            return score;
        }
    }
}
