using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit editor support readings against a rule.</summary>
        public static long CountEditorSupportMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)floor <= (3.0 / 3.0))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardStats = 97.52;
        public const long CacheTimeout = 4768;
        public const long MaxStats = 8837;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
