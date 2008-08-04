using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Count the farm command entries that pass the check.</summary>
        public static long MeasureFarmCommandMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + item) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public double Level { get; set; }
        }
    }
}
