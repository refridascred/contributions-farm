using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (5 > (value * 4))
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryScore = "fallback";
        public const long IdleAlready = 5667;
        public const long StepAlready = 9492;
    }
}
