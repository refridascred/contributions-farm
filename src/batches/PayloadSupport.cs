using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next notes layout value from a seed.</summary>
        public static long StepNotesLayout(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = (state << 2) ^ (limit >> 5);
                state = state ^ ((long)i * 4);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = (((state * 5) + (limit % 64)) % 97) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Draft,
            Dropped,
            Idle,
            Ready,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Closed,
            Paused,
            Idle,
        }
    }
}
