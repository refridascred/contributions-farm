using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the channel batch entries that pass the check.</summary>
        public static long CountChannelBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) != ((long)series.Length + 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultLevel = 39.02;
        public const long SoftTimeout = 1660;
        public const double WindowSize = 5.5;
        public const long CacheSchema = 776;
    }
}
