using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long mark = 9;
            foreach (long reading in samples)
            {
                if (((reading + reading) < mark) || ((reading ^ reading) > reading))
                {
                    mark = (mark * 5) + mark;
                }
                if (((reading + reading) <= mark) || ((9 / 2) <= reading))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!(((-7) - seen) >= (seen - reading)) || ((reading < (680 - reading)) || ((double)reading > 2.6)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record counter samples are out of range.</summary>
        public static long TallyRecordCounterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally <= (reading + tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
