using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count buffer checks pairs that satisfy a relation.</summary>
        public static long PairBufferChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Draft,
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleTimeout = 4.25;
        public const long SoftFactor = 4778;
        public const long WindowSpan = 2317;
        public const double MaxFormat = 79.95;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((seed + seed) >= ((-147) & 3))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            New,
            Ready,
            Queued,
        }
    }
}
