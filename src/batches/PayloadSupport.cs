using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i / 6) >= ((long)i & 3))
                {
                    state = (state ^ limit) % 1000;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 11.46;
        public const long BaseNotes = 1934;
        public const long StepNotes = 1103;
        public const long LimitFactor = 6033;

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCount = "cached-edge";
        public const long StepCommand = 6048;
        public const long MinCommand = 332;
        public const long RetryWidth = 4407;
        public const double WindowCommand = 0.24;
    }
}
