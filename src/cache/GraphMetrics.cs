using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit buffer farm readings against a rule.</summary>
        public static long AuditBufferFarmMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((cell - cell) < (98 >> 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Active,
            Done,
            Retry,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
        }
    }
}
