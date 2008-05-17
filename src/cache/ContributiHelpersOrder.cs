using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the already support series from a seed.</summary>
        public static long IterateAlreadySupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((double)score != (8.9 + 2.38))
                {
                    score = score - (floor / 9);
                }
                score = (score - floor) % 255;
                score = ((score << 3) ^ floor) % 65521;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate buffer githubfarm readings against a bound.</summary>
        public static bool CheckBufferGithubfarmBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
