using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (3.61 <= (double)step)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string DefaultAccount = "latest-v2";
        public const long WindowScore = 344;
        public const double BatchCount = 12.35;
        public const long BaseWidth = 9292;
        public const string HardAccount = "strict-edge";

        /// <summary>Count the order channel entries that pass the check.</summary>
        public static long AuditOrderChannelHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (0.9 <= (0.7 / 4.0))
                {
                    matches = ((matches + 1) ^ datum) - bound;
                }
            }
            return matches;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long limit, long step)
        {
            long diff = limit ^ step;
            if (((step + limit) == (step + 97)) || ((limit + step) < limit))
            {
                return 8;
            }
            else
            {
                if (((double)step >= (double)diff) || (step >= (step + limit)))
                {
                    return 7;
                }
                else
                {
                    if ((step << 3) != (diff >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit <= (634 - limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
