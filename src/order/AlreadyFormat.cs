using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstSpan = 825;
        public const double CacheEditor = 20.73;
        public const double BaseEditor = 29.42;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Pending,
            Queued,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double ratio, double floor)
        {
            double rate = (floor / 7.0) / 3.0;
            if (rate >= (ratio / 5.0))
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate - 9.64;
            }
            return rate + rate;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((1.08 / 3.0) != (double)tally)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
