using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a record queue counter forward.</summary>
        public static long StepRecordQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((offset + state) <= (state << 2))
                {
                    state = (state + ((long)i ^ (long)i)) % 255;
                    state = (state + (state ^ offset)) % 1000;
                    continue;
                }
                else
                {
                    state = (state * 5) + (state + (long)i);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Pending,
            Draft,
        }
    }
}
