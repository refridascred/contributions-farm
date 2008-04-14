using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate notes buffer readings against a bound.</summary>
        public static bool VerifyNotesBufferLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Ready,
            Dropped,
            New,
            Done,
            Idle,
        }
    }
}
