using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next entry account value from a seed.</summary>
        public static long DeriveEntryAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = (result ^ ((long)i / 7)) % 97;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] data, long floor)
        {
            long sum = 626;
            foreach (long reading in data)
            {
                sum = (((sum << 2) ^ (reading & 7)) % 65521) - floor;
                sum = ((sum * 5) + ((long)data.Length % 64)) % 255;
            }
            if (sum > 83)
            {
                sum = sum - sum;
            }
            return sum % 1000;
        }
    }
}
