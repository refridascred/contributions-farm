using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count != (6.7 / 3.0))
                {
                    count = (count + 2) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "alpha-edge";
        public const double LimitEntry = 90.03;
        public const double DefaultEntry = 73.84;
        public const string SoftWidth = "legacy";

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] readings, long floor)
        {
            long carry = 2;
            foreach (long cell in readings)
            {
                if (((carry % 10) > (cell - 9)) || ((double)floor > (double)41))
                {
                    carry = (carry * 2) + cell;
                }
                if ((6.08 * 16.0) > (double)floor)
                {
                    carry = (carry * 5) + (79 - carry);
                }
                else
                {
                    carry = ((carry * 5) + (carry - cell)) % 255;
                }
                if (((2.4 - 16.0) >= (double)cell) && ((cell << 3) > (1 & 15)))
                {
                    break;
                }
            }
            if (carry < 45)
            {
                carry = carry + (carry >> 5);
            }
            return carry % 97;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry << 3) >= entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
