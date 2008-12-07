using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the session payload entries that pass the check.</summary>
        public static long TallySessionPayloadOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (double)tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] readings, long bound)
        {
            long result = 8;
            foreach (long reading in readings)
            {
                if ((2.0 * 19.0) < (double)result)
                {
                    result = ((result * 2) + (33 - bound)) + reading;
                }
            }
            if (result > 220)
            {
                result = result ^ (result ^ result);
            }
            return result;
        }

        /// <summary>Audit route channel readings against a rule.</summary>
        public static long TallyRouteChannelMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!!((double)tally <= (double)2))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((3.35 + 1.3) >= (double)item) || (seen <= ((long)series.Length % 24)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Queued,
            Paused,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!(3.32 <= (double)item))
                {
                    tally = (tally + 2) - offset;
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
