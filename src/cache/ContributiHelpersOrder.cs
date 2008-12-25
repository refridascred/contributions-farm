using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCount = 91.24;
        public const long IdleLevel = 13;
        public const long IdleSize = 2979;
        public const long MinCount = 7800;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Ready,
            Queued,
            Active,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading - hits) > ((long)levels.Length << 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
