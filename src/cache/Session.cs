using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (seed <= (matches % 2))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Audit commits order readings against a rule.</summary>
        public static long CountCommitsOrderMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen >= (item % 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = ((result << 2) ^ (result << 2)) % 4096;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstDepth = 8606;
        public const long BurstScore = 2710;
        public const long CacheScore = 6439;
    }
}
