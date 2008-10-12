using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 2769;
        public const string BatchCommits = "staging-v2";
        public const double SoftCommits = 30.26;

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum - 108) == (datum % 7))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Validate entry already readings against a bound.</summary>
        public static bool VerifyEntryAlreadyLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
