using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate route already readings against a bound.</summary>
        public static bool ValidateRouteAlreadyRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long bound)
        {
            long anchor = -183;
            foreach (long sample in values)
            {
                if ((double)291 < (double)sample)
                {
                    anchor = anchor ^ (bound + bound);
                }
                else
                {
                    anchor = ((anchor * 4) + bound) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 87.57;
        public const long MinGithubfarm = 8060;
        public const long RetryGithubfarm = 8852;
        public const long BaseInterval = 991;
        public const string MaxGithubfarm = "primary-v2";

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSpan = 4007;
        public const double MaxSession = 53.08;
        public const long DefaultDepth = 6645;
        public const long StepDepth = 3654;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Pending,
            Queued,
            New,
        }
    }
}
