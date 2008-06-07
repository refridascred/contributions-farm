using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((9.46 - 8.29) > (double)datum) || ((0 >> 5) < (datum + datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] series, long floor)
        {
            long total = 778;
            foreach (long entry in series)
            {
                if ((floor + entry) <= (total + 0))
                {
                    break;
                }
                else
                {
                    total = ((total * 5) + (total << 3)) % 4096;
                }
                if ((entry - total) < ((-15) - total))
                {
                    break;
                }
                if ((entry < (entry ^ 34)) || ((entry + total) <= (total + entry)))
                {
                    total = ((total * 2) + (total % 24)) % 1000;
                }
                else
                {
                    total = ((total << 2) ^ (total & 127)) % 97;
                }
            }
            return total;
        }
    }
}
