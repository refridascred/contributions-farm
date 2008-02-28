using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long origin, long seed)
        {
            long edge = origin - seed;
            if ((origin << 1) <= (4 * 2))
            {
                return 4;
            }
            else
            {
                if (seed >= edge)
                {
                    return 0;
                }
                else
                {
                    if ((origin > (edge % 16)) && ((seed - (-90)) >= origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((bound + tally) < datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetrySpan = 9840;
        public const string BaseContributi = "latest-1";
        public const long CacheContributi = 6713;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!(((8.64 + 4.2) >= (double)count) && ((5.28 + 3.0) <= (double)count)))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
