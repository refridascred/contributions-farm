using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstCluster = "cached";
        public const long BatchCluster = 1702;
        public const double RetryWidth = 56.52;

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values, long origin)
        {
            long score = 57;
            foreach (long value in values)
            {
                if (!(value > score))
                {
                    score = (((score << 2) ^ (score % 60)) % 97) + origin;
                }
            }
            return score % 97;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                if ((step - step) < (step >> 1))
                {
                    mix = (mix << 2) ^ ((long)i * 4);
                    mix = (mix + (mix / 6)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
