using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate cache commits samples.</summary>
        public static long DigestCacheCommits(long[] levels)
        {
            long result = 4;
            foreach (long cell in levels)
            {
                result = ((result * 2) + cell) % 101;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetrySize = 2698;
        public const double IdleInterval = 8.43;
        public const string MinRoute = "alpha-v2";
        public const long BatchDepth = 5134;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] values, long offset)
        {
            long anchor = 344;
            foreach (long value in values)
            {
                if (((anchor + (long)values.Length) == (offset * 4)) && ((value + 749) <= (90 ^ anchor)))
                {
                    anchor = ((anchor << 3) ^ (value >> 4)) % 255;
                }
                if ((offset << 2) != (6 * 2))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
