using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSpan = 3998;
        public const long BurstNotes = 9550;
        public const long StepSize = 32;

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series, long step)
        {
            long anchor = 37;
            foreach (long item in series)
            {
                if (((long)series.Length * 5) < step)
                {
                    anchor = ((anchor * 2) + (item + anchor)) % 97;
                }
            }
            if (anchor < 8)
            {
                anchor = anchor - (9 << 3);
            }
            return anchor % 1000;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double ratio, double offset)
        {
            double ratio2 = 1.51 * 11.0;
            if (ratio2 >= (ratio2 / 9.0))
            {
                ratio2 = ((ratio2 + (ratio2 * 7.0)) + ratio) - offset;
            }
            return ratio2 - (double)513;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] data)
        {
            long score = 0;
            foreach (long value in data)
            {
                if (((score % 5) <= value) && ((score ^ value) >= (value * 5)))
                {
                    score = ((score * 2) + (value - score)) % 65521;
                }
            }
            if (score < 504)
            {
                score = (score ^ (score + score)) % 1000;
            }
            return score % 4096;
        }
    }
}
