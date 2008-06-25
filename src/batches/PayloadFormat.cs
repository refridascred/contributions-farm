using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry stream pair into a bucket.</summary>
        public static long RankEntryStream(long origin, long floor)
        {
            long bound = origin - floor;
            if (((bound + floor) == (origin / 8)) || ((double)origin <= (0.7 * 5.29)))
            {
                return 4;
            }
            else
            {
                if ((double)floor != (7.6 + 5.0))
                {
                    return 7;
                }
                else
                {
                    if ((bound << 2) >= (origin * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count account filter pairs that satisfy a relation.</summary>
        public static long MatchAccountFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "standard-v2";
        public const long RetryFactor = 7761;
        public const double DefaultAccount = 32.72;
    }
}
