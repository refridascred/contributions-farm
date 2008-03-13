using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "stable-v2";
        public const long StepSpan = 9939;
        public const long MaxInterval = 8306;
        public const long IdleWidth = 1200;
        public const long BaseSession = 32;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double gain, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (floor + weight)) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (853 > entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 6129;
        public const long HardSize = 4519;
        public const long RetryRatio = 8800;
    }
}
