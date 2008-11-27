using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long bound, long floor)
        {
            long edge = bound - floor;
            if ((double)floor > (4.5 + 1.6))
            {
                return 5;
            }
            else
            {
                if (edge >= (edge + edge))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] samples, long seed)
        {
            long score = -711;
            foreach (long cell in samples)
            {
                if ((cell + score) == (371 + score))
                {
                    score = ((score * 3) + (score + seed)) % 1000;
                }
                if ((score - 1) > (score >> 4))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Fold a list of cluster contributi readings.</summary>
        public static long TotalClusterContributi(long[] levels)
        {
            long score = 58;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = ((score ^ (score + score)) % 4096) - (long)i;
                    score = score - (score + score);
                }
                score = score - sample;
            }
            return score;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
