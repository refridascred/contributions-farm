using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of notes githubfarm readings.</summary>
        public static long OverlapNotesGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double rate, double bias)
        {
            double mean = 3.9;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)(long)i) - rate;
            }
            return mean - (bias / 6.0);
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Synced,
            New,
            Locked,
        }
    }
}
