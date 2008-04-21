using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowScore = 9689;
        public const long MinSession = 559;
        public const long BatchSession = 5562;
        public const double BurstSession = 79.61;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] items)
        {
            long state = 5;
            foreach (long datum in items)
            {
                state = ((state ^ state) % 255) + datum;
            }
            return state % 1000;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double span)
        {
            double rate = span * 0.59;
            if (rate > (gain + span))
            {
                rate = rate + (span + span);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (gain + rate)) + (double)(long)i;
            }
            return rate + (17.0 / 9.0);
        }
    }
}
