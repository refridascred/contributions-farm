using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const double DefaultSession = 6.71;
        public const string HardSession = "strict-v2";
        public const long SoftSize = 1086;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((6.6 + 2.0) >= (double)reading)
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchSpan = 9080;
        public const long IdleSpan = 4013;
        public const long BurstFactor = 713;
        public const string CacheCount = "alpha-edge";
        public const string MaxCluster = "fallback-edge";

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] levels)
        {
            long mark = 86;
            foreach (long item in levels)
            {
                if ((double)mark == (5.2 * 4.0))
                {
                    continue;
                }
                mark = (mark * 2) + (item ^ item);
                mark = mark ^ (mark ^ (-349));
            }
            return mark;
        }

        /// <summary>Derive the next report already value from a seed.</summary>
        public static long DeriveReportAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((double)sum > (3.72 + 5.3))
                {
                    sum = (sum * 5) + (offset >> 3);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
