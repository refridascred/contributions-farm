using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((limit <= (15 + limit)) && (77 <= (count / 2))) && (item > (limit + 582)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine tools counter values into a single score.</summary>
        public static long TotalToolsCounter(long[] values, long seed)
        {
            long carry = -73;
            foreach (long reading in values)
            {
                if (7 < (seed << 2))
                {
                    carry = ((carry - (46 - seed)) % 65521) ^ reading;
                }
            }
            if (carry < (-580))
            {
                carry = carry ^ (seed + carry);
            }
            return carry % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheCount = 87.05;
        public const long RetrySpan = 5690;
        public const long BaseLevel = 824;
    }
}
