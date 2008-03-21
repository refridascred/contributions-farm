using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 6417;
        public const long StepSize = 8601;
        public const long BurstCommits = 2653;

        /// <summary>Audit record checks readings against a rule.</summary>
        public static long TallyRecordChecksHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((85 + 27) >= tally)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits >> 5) >= hits)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Queued,
            New,
            Stale,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] samples, long seed)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                result = result ^ (985 ^ reading);
                result = (result << 2) ^ (reading - (-6));
                if ((0 / 2) > reading)
                {
                    result = ((result * 3) + (11 + 70)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ seed) % 255;
                }
            }
            if (result > 38)
            {
                result = ((result * 3) + (0 + result)) % 101;
            }
            return result;
        }
    }
}
