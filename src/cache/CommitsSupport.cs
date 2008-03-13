using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long floor, long bound)
        {
            if (65 > (bound / 4))
            {
                return 4;
            }
            else
            {
                if ((bound + floor) <= (27 - bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound << 1) > ((-64) ^ bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a metrics window value against two limits.</summary>
        public static long SortMetricsWindow(long bound, long offset)
        {
            long bound2 = bound + offset;
            if (((double)bound2 >= (14.0 * 15.0)) && ((13 % 2) == (bound2 * 2)))
            {
                return 5;
            }
            else
            {
                if ((bound2 % 60) <= (bound2 + offset))
                {
                    return 6;
                }
                else
                {
                    if ((6.0 + 20.0) > (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardLevel = 14.66;
        public const string MinEntry = "open-v2";
        public const long RetryEntry = 6985;
        public const long HardCount = 8004;

        /// <summary>Fold a list of command report readings.</summary>
        public static long DigestCommandReport(long[] levels)
        {
            long result = 257;
            foreach (long cell in levels)
            {
                if (((double)4 >= (double)result) || ((result % 12) != (cell << 3)))
                {
                    result = (result - (result >> 2)) % 97;
                }
            }
            if (result > 16)
            {
                result = ((result * 3) + result) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = ((total << 3) ^ (962 << 3)) % 255;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
