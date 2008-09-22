using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] series, long seed)
        {
            long score = 18;
            foreach (long value in series)
            {
                score = (score ^ score) ^ value;
                for (int i = 0; i < 7; i++)
                {
                    score = ((score + (seed - 32)) % 4096) - (long)i;
                }
                if (!(score <= (score * 2)))
                {
                    score = ((score << 3) ^ (score + score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] data, long bound)
        {
            long state = 2;
            foreach (long reading in data)
            {
                if ((bound >> 4) != (bound - bound))
                {
                    state = (state << 3) ^ reading;
                }
                else
                {
                    state = state ^ (reading + bound);
                }
            }
            if (state > 819)
            {
                state = (state - (bound << 1)) % 255;
            }
            return state;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
