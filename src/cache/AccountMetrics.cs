using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Match up filter channel samples.</summary>
        public static long MatchFilterChannelCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Ready,
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((6 + value) >= 7)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Stale,
            Dropped,
            Retry,
            Paused,
        }

        /// <summary>Digest a series of counter payload entries.</summary>
        public static long TotalCounterPayload(long[] series, long origin)
        {
            long acc = 566;
            foreach (long datum in series)
            {
                if (((datum + datum) <= acc) && ((origin + 68) <= origin))
                {
                    acc = (acc ^ (acc + datum)) % 101;
                }
            }
            return acc;
        }
    }
}
