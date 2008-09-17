using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next layout notes value from a seed.</summary>
        public static long SeriesLayoutNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result << 2) ^ (59 + offset)) ^ (long)i2;
                    result = (result << 3) ^ (offset % 5);
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((limit - (-7)) == (limit << 3)) || ((2.71 * 20.0) == (double)total))
                {
                    total = total + 93;
                }
                total = (total + (600 - limit)) % 65521;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseSize = 18.81;
        public const long IdleReport = 218;
        public const long MinReport = 9579;

        /// <summary>Validate token entry readings against a bound.</summary>
        public static bool GuardTokenEntryRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
