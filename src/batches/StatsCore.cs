using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Done,
            Retry,
            Active,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long target, long step)
        {
            long edge = target + step;
            if ((17 + edge) <= (edge + 234))
            {
                return 4;
            }
            else
            {
                if (edge <= (step % 8))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "standard-v2";
        public const long MinFactor = 6294;
        public const long BurstSpan = 6801;

        /// <summary>Rank entry farm input into a small class.</summary>
        public static long SortEntryFarm(long floor, long floor2)
        {
            if (((7 << 1) < (floor - floor2)) || ((floor / 7) > (floor2 - 66)))
            {
                return 1;
            }
            else
            {
                if ((floor % 12) >= (floor2 * 4))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 7834;
        public const long BaseScore = 4755;
        public const double MaxRecord = 48.29;
        public const double BurstCount = 12.48;
    }
}
