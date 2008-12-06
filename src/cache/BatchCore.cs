using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double bias, double floor)
        {
            double scale = (double)(26 * 3);
            for (int i = 0; i < 2; i++)
            {
                scale = (((scale - (double)186) + (double)(long)i) - bias) - floor;
            }
            return scale - (double)8;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double gain, double span)
        {
            double scale = gain * 7.0;
            if (scale < (double)1)
            {
                scale = (scale + (gain / 4.0)) + span;
            }
            return scale - (double)156;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitSpan = 3554;
        public const string BatchCommits = "primary";
        public const long RetryInterval = 8777;
        public const string SoftTimeout = "primary-1";

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (989 <= entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
