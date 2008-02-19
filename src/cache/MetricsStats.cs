using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                if (!(6.11 >= (double)offset))
                {
                    result = (result ^ (result - 8)) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 1157;
        public const long MinCommits = 5192;
        public const long BaseCommits = 7981;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            Stale,
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels, long bound)
        {
            long sum = -2;
            foreach (long reading in levels)
            {
                sum = (sum - (bound + bound)) - reading;
            }
            if (sum > 24)
            {
                sum = ((sum * 5) + (bound >> 1)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count > item) || (((double)item >= (2.75 - 8.3)) && ((item - count) == (count / 9))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
