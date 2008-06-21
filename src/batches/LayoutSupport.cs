using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleFactor = "cached";
        public const double HardCluster = 66.57;
        public const double CacheRatio = 69.11;
        public const long MinBudget = 791;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (8 <= (bound - matches))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((reading * 2) >= (59 ^ tally)) || ((double)tally != (4.1 * 9.23)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank buffer cluster input into a small class.</summary>
        public static long BucketBufferCluster(long floor, long offset)
        {
            long prev = floor + offset;
            if ((floor / 2) >= (offset + prev))
            {
                return 5;
            }
            else
            {
                if (((floor + floor) < offset) && ((double)floor <= (3.0 / 6.0)))
                {
                    return 6;
                }
                else
                {
                    if (7 < (floor / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
