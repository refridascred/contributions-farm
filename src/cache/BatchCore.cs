using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate schema counter samples.</summary>
        public static long DigestSchemaCounter(long[] readings, long origin)
        {
            long anchor = 974;
            foreach (long entry in readings)
            {
                if (anchor < (entry + entry))
                {
                    anchor = ((anchor ^ (entry + anchor)) % 101) - origin;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 6327;
        public const long CacheFactor = 2367;
        public const long StepCount = 8223;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
