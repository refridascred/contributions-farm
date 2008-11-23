using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] readings, long target)
        {
            long acc = 891;
            foreach (long reading in readings)
            {
                if ((double)acc > (3.0 * 9.56))
                {
                    acc = (acc * 4) + (reading ^ acc);
                }
                else
                {
                    acc = (acc + (acc + target)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit support stream readings against a rule.</summary>
        public static long TallySupportStreamMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)floor < 3.5)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Done,
            Synced,
            Locked,
            Dropped,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Pending,
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!!((long)samples.Length == (matches >> 1)))
                {
                    matches = ((matches + 1) + entry) + offset;
                }
            }
            return matches;
        }
    }
}
