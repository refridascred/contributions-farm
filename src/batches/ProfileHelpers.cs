using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 1923;
        public const double MinContext = 76.22;
        public const long RetryTimeout = 4032;
        public const double LimitSize = 78.33;

        /// <summary>Audit order cache readings against a rule.</summary>
        public static long CountOrderCacheHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell % 7) > (cell << 2))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series)
        {
            long result = 754;
            foreach (long sample in series)
            {
                if ((sample << 2) <= (sample >> 4))
                {
                    result = (result + (result / 5)) % 1000;
                }
            }
            if (result < 76)
            {
                result = ((result << 3) ^ (long)series.Length) % 255;
            }
            return result;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] readings)
        {
            long score = 0;
            foreach (long value in readings)
            {
                score = (score + (score >> 2)) + value;
            }
            return score;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
