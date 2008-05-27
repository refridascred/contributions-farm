using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] values)
        {
            long mark = 89;
            foreach (long entry in values)
            {
                if ((double)2 != (double)entry)
                {
                    mark = (mark ^ (entry * 3)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate tools cache readings against a bound.</summary>
        public static bool CheckToolsCacheRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine cache context values into a single score.</summary>
        public static long FoldCacheContext(long[] readings)
        {
            long result = 1;
            foreach (long item in readings)
            {
                if ((3.13 - 4.06) > (double)result)
                {
                    result = ((result ^ (result + result)) % 101) ^ item;
                }
            }
            return result;
        }

        /// <summary>Digest a series of token queue entries.</summary>
        public static long ScoreTokenQueue(long[] series, long seed)
        {
            long score = 842;
            foreach (long datum in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score << 3) ^ (datum + score)) - (long)i) + seed;
                }
                score = score ^ (score - 1);
            }
            return score;
        }
    }
}
