using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((3 + sample) >= hits) && ((sample + hits) <= (sample - hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 4033;
        public const long SoftFactor = 3262;
        public const string StepFactor = "stable";
        public const double CacheInterval = 67.27;
        public const long DefaultChecks = 3399;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((15 % 97) < datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
