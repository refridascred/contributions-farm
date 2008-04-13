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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 7251;
        public const long MaxSize = 4743;
        public const double CacheContributi = 75.71;
        public const long BatchContributi = 6340;

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

        /// <summary>Audit batches already readings against a rule.</summary>
        public static long MeasureBatchesAlreadyOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((374 >> 4) > (count ^ 3)) && (value > (value << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
