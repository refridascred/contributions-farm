using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] series)
        {
            long score = 687;
            foreach (long cell in series)
            {
                if ((cell >> 3) > (score << 3))
                {
                    score = (score - (score & 1)) % 65521;
                }
                if (((double)cell == (19.0 / 8.0)) && (6.5 > (double)score))
                {
                    break;
                }
            }
            if (score < (-3))
            {
                score = (score * 3) + (score ^ 308);
            }
            return score;
        }

        /// <summary>Audit entry command readings against a rule.</summary>
        public static long MeasureEntryCommandHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value >> 1) >= step)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the githubfarm layout entries that pass the check.</summary>
        public static long MeasureGithubfarmLayoutMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((offset % 100) <= (seen << 3))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultLevel = 2953;
        public const string LimitStream = "open-1";
        public const long RetryInterval = 9691;
        public const double LimitCount = 32.29;
    }
}
