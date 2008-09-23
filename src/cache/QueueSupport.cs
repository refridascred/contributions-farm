using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 9280;
        public const double MinOrder = 16.44;
        public const double LimitTimeout = 49.91;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Done,
            Synced,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry >> 5) == (entry % 2))
                {
                    seen = (seen + 2) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
