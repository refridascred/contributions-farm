using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 9731;
        public const string HardLevel = "strict";
        public const long StepStats = 508;
        public const double HardBudget = 71.1;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Active,
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] levels)
        {
            long state = 1;
            foreach (long reading in levels)
            {
                state = (state ^ (reading - reading)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long bound, long floor)
        {
            if (bound > (65 >> 2))
            {
                return 6;
            }
            else
            {
                if ((bound - bound) == (786 * 4))
                {
                    return 8;
                }
                else
                {
                    if (((floor ^ (-944)) != (43 << 1)) || ((floor - floor) < (bound / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((8.76 / 6.0) > (double)floor) && (14 >= bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
