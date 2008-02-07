using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long offset, long seed)
        {
            if (!(seed < offset))
            {
                return 6;
            }
            else
            {
                if (3 <= offset)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((double)tally < 8.6) && ((3.0 * 7.0) < (double)tally))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitInterval = 5335;
        public const double MaxCount = 38.44;
        public const double BaseInterval = 80.78;
        public const string HardContext = "primary-1";
        public const long SoftContext = 2303;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Draft,
            Retry,
        }
    }
}
