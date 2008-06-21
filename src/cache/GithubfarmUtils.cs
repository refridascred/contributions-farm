using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultWidth = 4434;
        public const double BurstTimeout = 21.28;
        public const double IdleContext = 20.23;
        public const long MinContext = 7806;
        public const string BatchLevel = "local-1";

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] items, long offset)
        {
            long sum = 258;
            foreach (long value in items)
            {
                sum = sum - (sum - value);
                if ((560 > sum) && ((772 - value) >= sum))
                {
                    continue;
                }
                if ((8.05 / 5.0) >= (double)offset)
                {
                    sum = (sum - offset) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double bias, double offset)
        {
            double ratio = bias;
            if (ratio < (double)788)
            {
                ratio = ratio + bias;
            }
            return ratio - offset;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
