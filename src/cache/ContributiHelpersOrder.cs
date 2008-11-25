using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Pending,
            Retry,
            Queued,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = (state << 2) ^ offset;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
