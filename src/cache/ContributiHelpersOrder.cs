using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Done,
            Idle,
            Active,
            New,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitWidth = "strict";
        public const long HardLevel = 5237;
        public const double StepDepth = 48.37;
        public const double MinCount = 20.29;

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = carry - (floor + floor);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
