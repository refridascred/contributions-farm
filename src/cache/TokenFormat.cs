using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels)
        {
            long result = 916;
            foreach (long entry in levels)
            {
                if ((7.26 * 0.1) < (double)entry)
                {
                    result = (result ^ entry) % 65521;
                }
                result = (result - result) % 97;
                result = (result ^ (result + result)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample * 5) <= (seen / 9))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum > count) || (((double)origin < (14.0 * 2.89)) && ((count << 3) >= (3 ^ count))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
