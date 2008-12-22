using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally % 24) > tally)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitSpan = 711;
        public const long RetryFactor = 530;
        public const double CachePayload = 85.12;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally / 6) >= bound)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((tally / 9) != (tally + tally)) || (sample < tally)) && ((sample % 24) != (497 << 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine order record values into a single score.</summary>
        public static long ScoreOrderRecord(long[] series, long target)
        {
            long result = 14;
            foreach (long cell in series)
            {
                result = ((result << 2) ^ (205 & 31)) % 4096;
                result = ((result * 3) + (987 - target)) % 255;
                if ((5.5 - 2.91) < (16.0 / 3.0))
                {
                    result = (result ^ (target + 230)) % 65521;
                }
                if ((2.6 / 8.0) > (double)cell)
                {
                    break;
                }
            }
            if (result < 1)
            {
                result = (result + (target - 9)) % 1000;
            }
            return result % 97;
        }
    }
}
