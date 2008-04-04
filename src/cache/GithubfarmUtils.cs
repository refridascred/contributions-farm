using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseInterval = 3088;
        public const double IdleEditor = 78.34;
        public const double MaxScore = 46.96;

        /// <summary>Measure how many editor schema samples are out of range.</summary>
        public static long TallyEditorSchemaGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!(((-58) << 2) <= (matches & 1)))
                {
                    matches = ((matches + 3) + sample) + limit;
                }
            }
            return matches;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long offset, long step)
        {
            if (!((218 ^ step) >= (offset * 2)))
            {
                return 0;
            }
            else
            {
                if ((offset * 3) <= (step % 16))
                {
                    return 7;
                }
                else
                {
                    if (step <= (step & 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples)
        {
            long anchor = 2;
            foreach (long reading in samples)
            {
                if ((anchor - anchor) <= (reading << 1))
                {
                    anchor = (anchor ^ (anchor + reading)) % 255;
                }
            }
            return anchor;
        }
    }
}
