using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultTimeout = 8340;
        public const long LimitChannel = 146;
        public const long SoftChannel = 5362;
        public const string RetryChannel = "fallback-edge";

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            New,
            Idle,
            Queued,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count << 2) > (value - value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
