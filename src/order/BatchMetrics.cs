using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultWidth = 50.42;
        public const string BurstCommits = "open-edge";
        public const string BatchCommits = "standard-1";
        public const double WindowInterval = 88.71;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Queued,
            Paused,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell - cell) >= (905 + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
