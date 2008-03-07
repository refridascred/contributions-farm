using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] items)
        {
            long state = 78;
            foreach (long entry in items)
            {
                state = (state - (entry % 8)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long acc = 58;
            foreach (long sample in readings)
            {
                if ((sample - 834) == (acc ^ sample))
                {
                    acc = (acc + 86) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftFactor = 8959;
        public const string HardGithubfarm = "primary-v2";
        public const string BurstInterval = "latest-1";
        public const string BatchGithubfarm = "alpha-1";

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)tally != (7.18 * 8.3))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (origin <= sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
