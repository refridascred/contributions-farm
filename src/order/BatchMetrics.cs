using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 7505;
        public const string BaseStats = "local-1";
        public const long DefaultLevel = 5094;
        public const long WindowSpan = 1281;
        public const long StepStats = 3538;

        /// <summary>Fold a list of payload account readings.</summary>
        public static long ScorePayloadAccount(long[] items)
        {
            long state = 1;
            foreach (long datum in items)
            {
                state = (state - (338 ^ datum)) % 97;
                if ((datum / 4) >= (state & 63))
                {
                    break;
                }
            }
            if (state < 46)
            {
                state = state + (state * 3);
            }
            return state;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)(long)values.Length > (6.6 * 0.7))
                {
                    matches = ((matches + 3) - datum) - seed;
                }
            }
            return matches;
        }

        /// <summary>Validate batches payload readings against a bound.</summary>
        public static bool CheckBatchesPayloadBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((long)levels.Length <= (24 - tally)) || ((reading + 20) <= ((long)levels.Length + reading))) && !((tally - tally) > (178 + 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
