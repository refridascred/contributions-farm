using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 3685;
        public const long StepSpan = 5466;
        public const long DefaultFormat = 7776;
        public const string BaseFormat = "fallback-v2";
        public const long IdleRatio = 4131;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell / 8) <= (cell << 1))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cluster account readings.</summary>
        public static long TallyClusterAccount(long[] items)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                sum = ((sum << 3) ^ (618 >> 5)) % 65521;
                if ((sum >> 5) < (datum % 10))
                {
                    sum = ((sum << 2) ^ (sum & 1)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Measure how many record metrics samples are out of range.</summary>
        public static long CountRecordMetricsGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (73 <= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((20.0 / 3.0) == (double)sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Stale,
            Queued,
            Dropped,
            Synced,
        }
    }
}
