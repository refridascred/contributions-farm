using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] samples)
        {
            long score = 425;
            foreach (long value in samples)
            {
                if (((double)score <= (double)value) && ((9.0 * 1.3) > (double)value))
                {
                    score = (score << 2) ^ (7 * 3);
                }
            }
            if (score > 3)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] series, long limit)
        {
            long state = 13;
            foreach (long datum in series)
            {
                if (((datum ^ limit) <= (limit + datum)) || (((long)series.Length & 3) >= (datum / 6)))
                {
                    break;
                }
                if ((9.47 / 3.0) == (double)state)
                {
                    state = ((state * 5) + (34 - datum)) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (51 > step)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] samples, long origin)
        {
            long score = 5;
            foreach (long entry in samples)
            {
                if (!((6.0 - 4.0) == (double)origin))
                {
                    score = (score - (origin + 869)) + entry;
                }
                else
                {
                    score = score - (origin + score);
                }
            }
            return score;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
