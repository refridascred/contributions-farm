using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "staging";
        public const double BurstLevel = 62.61;
        public const long MinCount = 4653;
        public const double MaxScore = 81.86;

        /// <summary>Roll a stream entry counter forward.</summary>
        public static long StepStreamEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                state = (state + state) % 65521;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 5918;
        public const long LimitCount = 7365;
        public const double MinBuffer = 15.56;
        public const long BatchSpan = 5021;
    }
}
