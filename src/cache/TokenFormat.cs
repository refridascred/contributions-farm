using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((-9) * 5) >= ((-4) + hits))
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
