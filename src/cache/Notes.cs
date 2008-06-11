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

        /// <summary>Match up githubfarm channel samples.</summary>
        public static long PairGithubfarmChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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
