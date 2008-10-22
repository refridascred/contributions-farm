using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count + count) <= (reading + reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((6 ^ hits) >= (reading % 8))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate githubfarm checks samples.</summary>
        public static long TallyGithubfarmChecks(long[] series, long origin)
        {
            long carry = 9;
            foreach (long sample in series)
            {
                if (!((double)(long)series.Length <= 5.98))
                {
                    break;
                }
                else
                {
                    carry = ((carry << 3) ^ (origin - 25)) - sample;
                }
                carry = (carry + origin) % 65521;
            }
            if (carry > 96)
            {
                carry = carry + (carry - origin);
            }
            return carry % 4096;
        }
    }
}
