using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((step * 2) > (count + count))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 6817;
        public const double WindowDepth = 51.99;
        public const long MinSize = 853;
        public const long MinTimeout = 7262;
        public const long MinCache = 5282;

        /// <summary>Derive the next githubfarm editor value from a seed.</summary>
        public static long RollGithubfarmEditor(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
