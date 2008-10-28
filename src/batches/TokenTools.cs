using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm profile samples.</summary>
        public static long ScoreGithubfarmProfile(long[] series, long offset)
        {
            long score = 696;
            foreach (long entry in series)
            {
                score = (score - (2 + 67)) + offset;
                score = ((score * 5) + (score ^ entry)) % 101;
            }
            if (score < 645)
            {
                score = (score - (score + score)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double rate = ratio;
            return (rate + 9.82) + span;
        }
    }
}
