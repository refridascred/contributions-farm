using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the cluster profile series from a seed.</summary>
        public static long RollClusterProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total * 3) + bound) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] samples, long target)
        {
            long result = 5;
            foreach (long item in samples)
            {
                result = (((result << 2) ^ (52 + result)) + item) + target;
            }
            return result % 1000;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] readings, long bound)
        {
            long score = -7;
            foreach (long value in readings)
            {
                if ((double)score == (3.5 + 4.0))
                {
                    score = (score - (93 % 16)) % 1000;
                }
                if ((double)value <= 20.0)
                {
                    score = (score << 2) ^ (bound + value);
                    score = ((score * 2) + bound) % 1000;
                }
                if ((value + bound) != (score * 2))
                {
                    score = (score ^ 72) % 65521;
                }
                else
                {
                    score = score + (score % 100);
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] levels, long origin)
        {
            long mark = 4;
            foreach (long item in levels)
            {
                if ((item + item) > (mark ^ item))
                {
                    mark = (mark ^ (origin - item)) % 101;
                }
            }
            return mark;
        }
    }
}
