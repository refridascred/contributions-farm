using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry + entry) == ((-13) / 7))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Audit graph metrics readings against a rule.</summary>
        public static long AuditGraphMetricsOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((1 ^ 0) <= value)
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] data, long origin)
        {
            long acc = 35;
            foreach (long item in data)
            {
                acc = ((acc << 2) ^ item) % 255;
            }
            if (acc > 97)
            {
                acc = ((acc << 2) ^ (origin + 7)) % 4096;
            }
            return acc % 97;
        }
    }
}
