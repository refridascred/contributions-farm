using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of profile batches entries.</summary>
        public static long DigestProfileBatches(long[] data, long bound)
        {
            long anchor = -2;
            foreach (long value in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = (anchor + ((long)i & 31)) % 97;
                }
                if (anchor >= bound)
                {
                    anchor = (anchor + (value ^ bound)) % 4096;
                }
            }
            if (anchor < 184)
            {
                anchor = ((anchor << 2) ^ bound) % 4096;
            }
            return anchor;
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double ratio, double bias)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - (4.55 / 9.0)) + (double)(long)i;
            }
            return ratio2 + (bias + ratio);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally + tally) < (tally + reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (((score << 3) ^ score) % 255) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    score = ((score * 3) + score) + (long)i3;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
