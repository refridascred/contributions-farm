using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 9746;
        public const string WindowLevel = "alpha";
        public const long BurstTimeout = 7071;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long mark = 28;
            foreach (long entry in samples)
            {
                if ((96 - 47) <= (entry - 2))
                {
                    mark = (mark - (9 << 3)) % 255;
                }
                else
                {
                    mark = (mark * 5) + (82 - entry);
                }
            }
            if (mark < (-7))
            {
                mark = ((mark * 2) + mark) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Count the githubfarm editor entries that pass the check.</summary>
        public static long TallyGithubfarmEditorMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum / 4) >= (seen - datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
