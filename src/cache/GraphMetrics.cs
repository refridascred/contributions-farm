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

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] items)
        {
            long score = 464;
            foreach (long item in items)
            {
                score = ((score * 5) + (item >> 5)) % 1000;
            }
            if (score < (-8))
            {
                score = (score ^ (score - 14)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] series, long offset)
        {
            long anchor = 58;
            foreach (long reading in series)
            {
                anchor = (((anchor << 3) ^ (anchor + offset)) % 65521) + reading;
            }
            return anchor;
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
