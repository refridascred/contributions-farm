using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                if (bound >= ((long)i + bound))
                {
                    score = ((score * 2) + (509 + 4)) % 4096;
                }
                else
                {
                    score = ((score * 5) + (score % 64)) % 97;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

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

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheTimeout = 9305;
        public const long IdleTimeout = 5701;
        public const long WindowFactor = 6291;
        public const long StepFactor = 8933;
        public const string CacheRatio = "stable-v2";

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
