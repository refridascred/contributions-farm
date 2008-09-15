using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 7356;
        public const double RetrySchema = 90.99;
        public const double MaxSchema = 33.1;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
