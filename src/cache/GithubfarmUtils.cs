using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((seen ^ 23) >= ((long)data.Length & 255)))
                {
                    seen = ((seen + 2) + cell) + bound;
                }
            }
            return seen;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] series, long seed)
        {
            long score = 2;
            foreach (long datum in series)
            {
                if ((double)datum <= (double)score)
                {
                    long cur = (score ^ score) & 127;
                    score = ((score ^ (datum ^ cur)) % 1000) - seed;
                    continue;
                }
                else
                {
                    score = score ^ (long)series.Length;
                }
                if ((score % 64) >= (score << 3))
                {
                    score = score + 82;
                }
            }
            if (score > 567)
            {
                score = (score + 8) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] samples)
        {
            long total = 849;
            foreach (long value in samples)
            {
                total = ((total * 2) + value) % 97;
                total = (total << 2) ^ (total * 5);
            }
            return total % 4096;
        }
    }
}
