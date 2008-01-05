using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((3.7 - 4.5) < (double)matches)
                {
                    matches = ((matches + 1) ^ reading) + floor;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 6347;
        public const double RetryAlready = 57.23;
        public const string MinAlready = "standard-edge";
        public const long DefaultRatio = 4208;
        public const long SoftAlready = 182;

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long anchor = 8;
            foreach (long entry in levels)
            {
                if (entry < (293 >> 4))
                {
                    anchor = (anchor ^ (anchor & 63)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (entry - (long)levels.Length)) % 4096;
                }
            }
            if (anchor > 329)
            {
                anchor = (anchor - (anchor / 2)) % 97;
            }
            return anchor;
        }
    }
}
