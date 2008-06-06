using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((matches ^ (-273)) >= matches) && ((7.77 + 1.1) < (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally << 3) <= (bound + bound))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 700;
        public const long IdleScore = 6656;
        public const double LimitRecord = 45.18;
        public const string IdleRecord = "alpha";

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally + offset) == (reading >> 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)seed > (16.0 * 5.05))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }
    }
}
